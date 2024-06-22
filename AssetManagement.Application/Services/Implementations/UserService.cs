using AssetManagement.Application.Common.Constants;
using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using AssetManagement.Domain.Constants;
using Microsoft.AspNetCore.Mvc;
using AssetManagement.Domain.Enums;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;

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

    public async Task<PagingDto<FilterUserResponse>> FilterUserAsync(FilterUserRequest request)
    {
        var queryable = _userManager.Users;

        var currentUser = await _userManager.FindByIdAsync(_currentUser.UserId.ToString())
            .ContinueWith(t => t.Result ?? throw new UnauthorizedAccessException("User do not login"));

        //set default page size
        if (!request.PageNumber.HasValue || !request.PageSize.HasValue
            || request.PageNumber.Value <= 0 || request.PageSize.Value <= 0)
        {
            request.PageNumber = 1;
            request.PageSize = 5;
        }

        try
        {
            var orderBy = GetOrderByExpression(request);

            Expression<Func<AppUser, bool>> filterSpecification = u => (string.IsNullOrEmpty(request.Name) || (u.FirstName + u.LastName).Contains(request.Name) || u.StaffCode.Contains(request.Name))
            && (request.Types == null || !request.Types.Any() || request.Types.Contains(u.UserRoles.Select(ur => ur.Role.Name).FirstOrDefault())
            && u.Location == currentUser.Location);

            var totalRecord = await queryable.CountAsync();

            queryable = orderBy(queryable);

            var result = await queryable
                .AsNoTracking()
                .Where(filterSpecification)
                .Skip((request.PageNumber.Value - 1) * request.PageSize.Value)
                .Take(request.PageSize.Value)
                .Select(u => new FilterUserResponse()
                {
                    Id = u.Id,
                    FullName = $"{u.FirstName} {u.LastName}",
                    JoinedDate = u.JoinedDate,
                    StaffCode = u.StaffCode,
                    Username = u.UserName,
                    Types = u.UserRoles.Select(ur => ur.Role.Name).ToList()
                }).ToListAsync();

            var totalPages = (int)Math.Ceiling((double)totalRecord / request.PageSize.Value);
            return new PagingDto<FilterUserResponse>()
            {
                CurrentPage = request.PageNumber.Value,
                TotalItemCount = totalRecord,
                PageSize = request.PageSize.Value,
                Data = result
            };
        }
        catch (Exception e)
        {
            _logger.LogError("Error when execute {} method.\nDate: {}.\nDetail: {}", nameof(this.FilterUserAsync),
                DateTime.UtcNow, e.Message);
            throw new Exception($"Error when execute {nameof(this.FilterUserAsync)} method");
        }
    }

    public async Task<UserInfoResponse> GetUserByIdAsync(Guid id)
    {
        try
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
        catch (Exception e)
        {
            _logger.LogError("Error when execute {} method.\nDate: {}.\nDetail: {}", nameof(this.GetUserByIdAsync),
                DateTime.UtcNow, e.Message);
            throw new Exception($"Error when execute {nameof(this.GetUserByIdAsync)} method");
        }
    }

    public async Task<UserInfoResponse> CreateUserAsync(CreateUserRequest request)
    {
        try
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
            var password = userName + Constants.PASSWORD_SEPERATOR + request.DateOfBirth.ToString("ddmmyyyy");

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
                CreatedDateTime = DateTime.UtcNow,
                LastUpdatedDateTime = DateTime.UtcNow,
            };

            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, request.Type);
                return _mapper.Map<UserInfoResponse>(user);
            }
            throw new Exception(string.Join(". ", result.Errors.Select(p => p.Description)));
        }
        catch (Exception e)
        {
            _logger.LogError("Error when execute {} method.\nDate: {}.\nDetail: {}", nameof(this.CreateUserAsync),
                DateTime.UtcNow, e.Message);
            throw new Exception($"Error when execute {nameof(this.CreateUserAsync)} method");
        }
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

		_logger.LogInformation("Updating user with ID: {UserId}", userId);
        var queryable = _userManager.Users;
        AppUser userToUpdate = await queryable.Where(q => q.Id == userId).Include(q => q.UserRoles).ThenInclude(q => q.Role).FirstOrDefaultAsync() ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
        userToUpdate.DateOfBirth = request.DateOfBirth;
        userToUpdate.JoinedDate = request.JoinedDate;
        userToUpdate.Gender = request.Gender;
        userToUpdate.LastUpdatedDateTime = DateTime.UtcNow;
            
        IList<String> currentRoles = await _userManager.GetRolesAsync(userToUpdate);
        if (!currentRoles.Contains(request.Type))
        {
            Role? updateRoles = await _roleManager.FindByNameAsync(request.Type);

            if (updateRoles is null)
            {
                throw new BadRequestException(ErrorStrings.ROLE_NOT_EXIST);
            }
            userToUpdate.UserRoles = new List<UserRole> { new UserRole() {
                UserId = userId,
                RoleId = updateRoles.Id
            } };
         }

        IdentityResult updateResult = await _userManager.UpdateAsync(userToUpdate);
        if (!updateResult.Succeeded)
        {
            throw new BadRequestException(ErrorStrings.USER_UPDATE);
        }
        UserInfoResponse response = _mapper.Map<UserInfoResponse>(userToUpdate);
        _logger.LogInformation("User updated successfully: {UserId}", userId);
        return response;
    }

    #region Private methods
    private Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> GetOrderByExpression(FilterUserRequest filter)
    {
        Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> orderBy = q =>
                q.OrderBy(u => u.FirstName + u.LastName);

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
            orderBy = q => q.OrderBy(u => u.FirstName + u.LastName);
        }
        else if (filter.SortJoinedDate != null && filter.SortJoinedDate.Equals(SortOption.Desc))
        {
            orderBy = q => q.OrderByDescending(u => u.FirstName + u.LastName);
        }
        else if (filter.SortType != null && filter.SortType.Equals(SortOption.Asc))
        {
            orderBy = q => q.OrderBy(u => u.FirstName + u.LastName);
        }
        else if (filter.SortType != null && filter.SortType.Equals(SortOption.Desc))
        {
            orderBy = q => q.OrderByDescending(u => u.FirstName + u.LastName);
        }

        return orderBy;
    }

    private void ValidateFirstName(string firstName)
    {
        if (firstName.Split(' ').Length > Constants.NUMBER_OF_WORDS_IN_FIRSTNAME) throw new BadRequestException(ErrorStrings.INVALID_FIRSTNAME_NUMBER_OF_WORDS);
        if (firstName.All(c => char.IsLetter(c))) throw new BadRequestException(ErrorStrings.INVALID_FIRSTNAME_CHARACTERS);
    }

    private void ValidateLastName(string lastname)
    {
        if (lastname.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) throw new BadRequestException(ErrorStrings.INVALID_LASTNAME_CHARACTERS);
    }

    private async Task<Role> ValidateTypeAsync(string type)
    {
        var role = await _roleManager.Roles.Where(r => r.Name!.ToLower() == type.ToLower()).FirstOrDefaultAsync();
        if (role == null) throw new BadRequestException(ErrorStrings.INVALID_ROLE);
        return role;
    }

    private void ValidateGender(string gender)
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

    private async Task<string> GetAndValidateLocationAsync()
    {
        var currentAdminId = _currentUser.UserId;
        var adminUser = await _userManager.FindByIdAsync(currentAdminId.ToString()) ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
        if (adminUser.Location == null) throw new Exception(ErrorStrings.INVALID_LOCATION);
        return adminUser.Location;
    }

    private void ValidateDateOfBirth(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        if (now < dateOfBirth) throw new BadRequestException(ErrorStrings.INVALID_DATE_OF_BIRTH_IN_FUTURE);
        if (dateOfBirth.AddYears(Constants.MINIMUM_AGE) > now) throw new BadRequestException(ErrorStrings.INVALID_DATE_OF_BIRTH);
    }

    private void ValidateJoinedDate(DateTime dateOfBirth, DateTime joinedDate)
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
            int number = 0;
            string numberStr = Regex.Match(latestUserContainsSameUsername.UserName, @"\d+").Value;
            if (int.TryParse(numberStr, out number) && number > 0)
            {
                userName = userName + (number + 1).ToString();
            }
            else
            {
                userName = userName + "1";
            }
        }
        return userName;
    }
    #endregion
}

