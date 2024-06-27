using AssetManagement.Application.Common.Constants;
using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace AssetManagement.Application.Services.Implementations;
public class UserService : IUserService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ILogger<UserService> _logger;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;
    private readonly RoleManager<Role> _roleManager;

    public UserService(UserManager<AppUser> userManager, ILogger<UserService> logger, ICurrentUser currentUser, IMapper mapper, RoleManager<Role> roleManager)
    {
        _userManager = userManager;
        _logger = logger;
        _currentUser = currentUser;
        _mapper = mapper;
        _roleManager = roleManager;
    }

    public async Task<PagingDto<FilterUserResponse>> FilterUserAsync(FilterUserRequest filter)
    {
        var queryable = _userManager.Users;

        var currentUser = await queryable
            .Where(u => _currentUser.UserId.Equals(u.Id))
            .FirstOrDefaultAsync()
            .ContinueWith(t => t.Result ?? throw new UnauthorizedAccessException(ErrorStrings.USER_NOT_LOGIN));

        if (currentUser.IsDisabled)
        {
            throw new UnauthorizedAccessException(ErrorStrings.USER_IS_DISABLED);
		}

		//set default page size
		if (!filter.PageNumber.HasValue || !filter.PageSize.HasValue
            || filter.PageNumber.Value <= 0 || filter.PageSize.Value <= 0)
        {
			filter.PageNumber = 1;
			filter.PageSize = 5;
        }

        var orderBy = GetOrderByExpression(filter);

        Expression<Func<AppUser, bool>> filterSpecification = u =>
           (string.IsNullOrEmpty(filter.Name) || (u.FirstName + " " + u.LastName).Contains(filter.Name) || u.StaffCode.Contains(filter.Name))
            && (filter.Types == null || filter.Types.Length == 0 || filter.Types.Contains(u.UserRoles.Select(ur => ur.Role.Name).FirstOrDefault()))
            && u.Location == currentUser.Location
            && !u.IsDisabled;

        var totalRecord = await queryable.Where(filterSpecification).CountAsync();

        queryable = orderBy(queryable);

        var result = await queryable
            .AsNoTracking()
            .Where(filterSpecification)
            .Skip((filter.PageNumber.Value - 1) * filter.PageSize.Value)
            .Take(filter.PageSize.Value)
            .Select(u => new FilterUserResponse()
            {
                Id = u.Id,
                FullName = $"{u.FirstName} {u.LastName}",
                JoinedDate = u.JoinedDate,
                StaffCode = u.StaffCode,
                Username = u.UserName,
                Types = u.UserRoles.Select(ur => ur.Role.Name).ToList()
            }).ToListAsync();

        return new PagingDto<FilterUserResponse>()
        {
            CurrentPage = filter.PageNumber.Value,
            TotalItemCount = totalRecord,
            PageSize = filter.PageSize.Value,
            Data = result
        };
    }

    public async Task<UserInfoResponse> GetUserByIdAsync(Guid id)
    {
        var queryable = _userManager.Users;
        var appUser = await queryable.Where(q => q.Id == id).Include(q => q.UserRoles).ThenInclude(q => q.Role).FirstOrDefaultAsync();
        if (appUser == null)
        {
            throw new NotFoundException("User can not found");
        }
        var result = _mapper.Map<UserInfoResponse>(appUser);
        return result;
    }

    public async Task<UserInfoResponse> CreateUserAsync(CreateUserRequest request)
    {
        ValidateFirstName(request.FirstName);
        ValidateLastName(request.LastName);
        ValidateGender(request.Gender);
        ValidateDateOfBirth(request.DateOfBirth);
        ValidateJoinedDate(request.DateOfBirth, request.JoinedDate);
        await ValidateTypeAsync(request.Type);

        var firstName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(request.FirstName.ToLower());
        var lastName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(request.LastName.ToLower());
        var userName = await GenerateUsernameAsync(firstName, lastName);
        var password = userName + Constants.PASSWORD_SEPERATOR + request.DateOfBirth.ToString("ddMMyyyy");

        var user = new AppUser()
        {
            UserName = userName,
            FirstName = firstName,
            LastName = lastName,
            Email = userName + Constants.EMAIL_SUFFIX,
            Gender = request.Gender,
            Location = await GetAndValidateLocationAsync(),
            DateOfBirth = request.DateOfBirth,
            JoinedDate = request.JoinedDate,
            IsPasswordChanged = false,
            StaffCode = await GenerateStaffCodeAsync(),
            IsDisabled = false,
            CreatedDateTime = DateTime.Now,
            LastUpdatedDateTime = DateTime.Now,
        };

        var result = await _userManager.CreateAsync(user, password);
        if (result.Succeeded)
        {
            Role? role = await _roleManager.FindByNameAsync(request.Type);
            user.UserRoles = new List<UserRole> { new UserRole() {
                UserId = user.Id,
                RoleId = role!.Id
            } };
            IdentityResult updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                throw new BadRequestException(ErrorStrings.CANNOT_ADD_ROLE_TO_USER);
            }
            return _mapper.Map<UserInfoResponse>(user);
        }
        throw new Exception(string.Join(". ", result.Errors.Select(p => p.Description)));
    }

    public async Task<DisableUserResponse> DisableUserAsync(Guid id)
    {
        var userToBeDisabled = await _userManager.FindByIdAsync(id.ToString()) ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
        userToBeDisabled.IsDisabled = true;
        var result = await _userManager.UpdateAsync(userToBeDisabled);
        if (result.Succeeded)
        {
            return new DisableUserResponse();
        }
        throw new Exception(string.Join(". ", result.Errors.Select(p => p.Description)));
    }
    public async Task<UserInfoResponse> UpdateUserAsync(Guid userId, UpdateUserRequest request)
    {
		ValidateGender(request.Gender);
        ValidateDateOfBirth(request.DateOfBirth);
        ValidateJoinedDate(request.DateOfBirth, request.JoinedDate);
        await ValidateTypeAsync(request.Type);
        await ValidateLocationAsync(userId);

        _logger.LogInformation("Updating user with ID: {UserId}", userId);
        var queryable = _userManager.Users;
        AppUser userToUpdate = await queryable.Where(q => q.Id == userId).Include(q => q.UserRoles).ThenInclude(q => q.Role).FirstOrDefaultAsync() ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
        userToUpdate.DateOfBirth = request.DateOfBirth;
        userToUpdate.JoinedDate = request.JoinedDate;
        userToUpdate.Gender = request.Gender;
        userToUpdate.LastUpdatedDateTime = DateTime.Now;

        IList<String> currentRoles = await _userManager.GetRolesAsync(userToUpdate);
        if (!currentRoles.Contains(request.Type))
        {
            Role? updateRoles = await _roleManager.FindByNameAsync(request.Type);
            userToUpdate.UserRoles = new List<UserRole> { new UserRole() {
                UserId = userId,
                RoleId = updateRoles!.Id
            } };
        }

        IdentityResult updateResult = await _userManager.UpdateAsync(userToUpdate);
        if (!updateResult.Succeeded)
        {
            throw new BadRequestException(ErrorStrings.CANNOT_UPDATE_USER);
        }
        UserInfoResponse response = _mapper.Map<UserInfoResponse>(userToUpdate);
        _logger.LogInformation("User updated successfully: {UserId}", userId);
        return response;
    }

    #region Private methods
    private Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> GetOrderByExpression(FilterUserRequest filter)
    {
        Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = q =>
                q.OrderByDescending(u => u.JoinedDate);

        if (filter.SortStaffCode != null && filter.SortStaffCode.Equals(SortOption.Asc))
        {
            orderBy = q => q.OrderBy(u => u.StaffCode);
        }
        else if (filter.SortStaffCode != null && filter.SortStaffCode.Equals(SortOption.Desc))
        {
            orderBy = q => q.OrderByDescending(u => u.StaffCode);
        }
        else if (filter.SortFullName != null && filter.SortFullName.Equals(SortOption.Asc))
        {
            orderBy = q => q.OrderBy(u => u.FirstName + u.LastName);
        }
        else if (filter.SortFullName != null && filter.SortFullName.Equals(SortOption.Desc))
        {
            orderBy = q => q.OrderByDescending(u => u.FirstName + u.LastName);
        }
        else if (filter.SortJoinedDate != null && filter.SortJoinedDate.Equals(SortOption.Asc))
        {
            orderBy = q => q.OrderBy(u => u.JoinedDate);
        }
        else if (filter.SortJoinedDate != null && filter.SortJoinedDate.Equals(SortOption.Desc))
        {
            orderBy = q => q.OrderByDescending(u => u.JoinedDate);
        }
        else if (filter.SortType != null && filter.SortType.Equals(SortOption.Asc))
        {
            orderBy = q => q.OrderBy(u => u.UserRoles.Select(ur => ur.Role.Name).FirstOrDefault());
        }
        else if (filter.SortType != null && filter.SortType.Equals(SortOption.Desc))
        {
            orderBy = q => q.OrderByDescending(u => u.UserRoles.Select(ur => ur.Role.Name).FirstOrDefault());
        }
        else if (filter.SortLastUpdate != null && filter.SortLastUpdate.Equals(SortOption.Asc))
        {
            orderBy = q => q.OrderBy(u => u.LastUpdatedDateTime);
        }
        else if (filter.SortLastUpdate != null && filter.SortLastUpdate.Equals(SortOption.Desc))
        {
            orderBy = q => q.OrderByDescending(u => u.LastUpdatedDateTime);
        }
        return orderBy;
    }

    private static void ValidateFirstName(string firstName)
    {
        if (firstName.Split(' ').Length > Constants.NUMBER_OF_WORDS_IN_FIRSTNAME) throw new BadRequestException(ErrorStrings.INVALID_FIRSTNAME_NUMBER_OF_WORDS);
        if (!Regex.IsMatch(firstName, @"^[a-zA-Z]+$")) throw new BadRequestException(ErrorStrings.INVALID_FIRSTNAME_CHARACTERS);
    }

    private static void ValidateLastName(string lastname)
    {
        if (!Regex.IsMatch(lastname, @"^[a-zA-Z\s]+$")) throw new BadRequestException(ErrorStrings.INVALID_LASTNAME_CHARACTERS);
    }

    private async Task<Role> ValidateTypeAsync(string type)
    {
        var roles = await _roleManager.Roles.ToListAsync();
        var role = roles.Find(r => r.Name!.Equals(type, StringComparison.CurrentCultureIgnoreCase));

        if (role == null)
        {
            throw new BadRequestException(ErrorStrings.INVALID_ROLE);
        }

        return role;
    }

    private static void ValidateGender(string gender)
    {
        if (!Enum.TryParse(gender, out Gender resultGender)) throw new BadRequestException(ErrorStrings.INVALID_GENDER);
    }

    private async Task<string> GenerateStaffCodeAsync()
    {
        var latestStaff = await _userManager.Users.OrderByDescending(u => u.StaffCode).FirstOrDefaultAsync();
        var newStaffCode = Constants.STAFFCODE_PREFIX;
        if (latestStaff != null)
        {
            string numberStr = Regex.Match(latestStaff.StaffCode, @"\d+").Value;
            newStaffCode += (int.Parse(numberStr) + 1).ToString().PadLeft(Constants.PADDING_STAFFCODE_NUMBERS, '0');
        }
        else
        {
            newStaffCode += "1".ToString().PadLeft(Constants.PADDING_STAFFCODE_NUMBERS, '0');
        }

        return newStaffCode;
    }
    private async Task ValidateLocationAsync(Guid userId)
    {
        var adminId = _currentUser.UserId;
		var adminUser = await _userManager.FindByIdAsync(adminId.ToString()) ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);

		var currentUser = await _userManager.FindByIdAsync(userId.ToString()) ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
        if (adminUser.Location != currentUser.Location)
        {
            throw new BadRequestException(ErrorStrings.LOCATION_NOT_VALID);
        }
	}
    private async Task<string> GetAndValidateLocationAsync()
    {
        var currentAdminId = _currentUser.UserId;
        var adminUser = await _userManager.FindByIdAsync(currentAdminId.ToString()) ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
        if (adminUser.Location == null) throw new Exception(ErrorStrings.INVALID_LOCATION);
        return adminUser.Location;
    }

    private static void ValidateDateOfBirth(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        if (now < dateOfBirth) throw new BadRequestException(ErrorStrings.INVALID_DATE_OF_BIRTH_IN_FUTURE);
        if (dateOfBirth.AddYears(Constants.MINIMUM_AGE) > now) throw new BadRequestException(ErrorStrings.INVALID_DATE_OF_BIRTH);
    }

    private static void ValidateJoinedDate(DateTime dateOfBirth, DateTime joinedDate)
    {
        if ((joinedDate.DayOfWeek == DayOfWeek.Saturday) || (joinedDate.DayOfWeek == DayOfWeek.Sunday))
            throw new BadRequestException(ErrorStrings.INVALID_JOINED_DATE_RELATE_TO_WEEKDAY);
        if (dateOfBirth.AddYears(Constants.MINIMUM_AGE) > joinedDate)
            throw new BadRequestException(ErrorStrings.INVALID_JOINED_DATE_RELATE_TO_DOB);
    }

    private async Task<string> GenerateUsernameAsync(string firstName, string lastName)
    {
        var userName = firstName.ToLower() + string.Join("", lastName.Split([' ']).Select(word => word.First())).ToLower();

        var latestUserContainsSameUsername = await _userManager.Users.Where(u => u.UserName!.Contains(userName)).OrderByDescending(u => u.UserName).FirstOrDefaultAsync();
        if (latestUserContainsSameUsername != null && latestUserContainsSameUsername.UserName != null)
        {
            string numberStr = Regex.Match(latestUserContainsSameUsername.UserName, @"\d+").Value;
            if (int.TryParse(numberStr, out int number) && number > 0)
            {
                userName += (number + 1).ToString();
            }
            else
            {
                userName += "1";
            }
        }
        return userName;
    }
    #endregion
}

