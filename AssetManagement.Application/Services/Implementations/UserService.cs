using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Application.Common.Constants;
using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using AssetManagement.Domain.Constants;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Mvc;
using AssetManagement.Domain.Enums;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Security.Claims;
using AssetManagement.Domain.Enums;
using Azure.Core;

namespace AssetManagement.Application.Services.Implementations;
public class UserService : IUserService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ILogger<UserService> _logger;
    private readonly ICurrentUser _currentUser;
    private readonly IMapper _mapper;
	private readonly RoleManager<Role> _roleManager;

	public UserService(UserManager<AppUser> userManager, RoleManager<Role> roleManager, ILogger<UserService> logger, ICurrentUser currentUser, IMapper mapper)
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly RoleManager<UserRole> _roleManager;
    private readonly PasswordHasher<AppUser> _passwordHasher;

    public UserService(UserManager<AppUser> userManager, ILogger<UserService> logger, ICurrentUser currentUser, IMapper mapper, 
        IHttpContextAccessor contextAccessor, RoleManager<UserRole> roleManager, PasswordHasher<AppUser> passwordHasher)
    {
        _userManager = userManager;
        _logger = logger;
        _currentUser = currentUser;
        _mapper = mapper;
        _contextAccessor = contextAccessor;
        _roleManager = roleManager;
        _passwordHasher = passwordHasher;
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

    public async Task<UserInfoResponse> GetUserById(Guid id)
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
            _logger.LogError("Error when execute {} method.\nDate: {}.\nDetail: {}", nameof(this.GetUserById),
                DateTime.UtcNow, e.Message);
            throw new Exception($"Error when execute {nameof(this.GetUserById)} method");
        }
    }

    public async Task<UserInfoResponse> CreateUserAsync(CreateUserRequest request)
    {
        try
        {
            ValidateFirstName(request.FirstName);
            ValidateType(request.Type);
            ValidateGender(request.Gender);
            ValidateDateOfBirth(request.DateOfBirth);
            ValidateJoinedDate(request.DateOfBirth, request.JoinedDate);

            var firstName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(request.FirstName);
            var lastName = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(request.LastName);
            var userName = await GenerateUsernameAsync(firstName, lastName);
            var password = userName + Constants.PASSWORD_SEPERATOR + request.DateOfBirth.ToString("ddmmyyyy");

            var user = new AppUser()
            {
                UserName = userName,
                NormalizedUserName = userName.Normalize(),
                FirstName = firstName,
                LastName = lastName,
                Gender = Enum.Parse(typeof(Gender), request.Gender).ToString(),
                Location = (await GetAndValidateLocationAsync()).ToString(),
                IsPasswordChanged = false,
                StaffCode = await GenerateStaffCodeAsync(),
                IsDisabled = false,
                CreatedDateTime = DateTime.UtcNow,
                LastUpdatedDateTime = DateTime.UtcNow,
            };
            var hashedPassword = _passwordHasher.HashPassword(user, password);
            user.PasswordHash = hashedPassword;

            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded) return _mapper.Map<UserInfoResponse>(user);
            throw new Exception(string.Join(". ", result.Errors.Select(p => p.Description)));
        }
        catch (Exception e)
        {
            _logger.LogError("Error when execute {} method.\nDate: {}.\nDetail: {}", nameof(this.CreateUserAsync),
                DateTime.UtcNow, e.Message);
            throw new Exception($"Error when execute {nameof(this.CreateUserAsync)} method");
        }
    }

    public async Task<DisableUserResponse> DisableUserAsync(DisableUserRequest request)
    {
        try
        {
            var userToBeDisabled = await _userManager.FindByIdAsync(request.UserId) ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
            userToBeDisabled.IsDisabled = true;
            var result = await _userManager.UpdateAsync(userToBeDisabled);
            if (result.Succeeded)
            {
                return new DisableUserResponse();
            }
            throw new Exception(string.Join(". ", result.Errors.Select(p => p.Description)));
        }
        catch (Exception e)
        {
            _logger.LogError("Error when execute {} method.\nDate: {}.\nDetail: {}", nameof(this.DisableUserAsync),
                DateTime.UtcNow, e.Message);
            throw new Exception($"Error when execute {nameof(this.DisableUserAsync)} method");
        }
    }

    public async Task<DisableUserResponse> DisableUserAsync(DisableUserRequest request)
    {
        try
        {
            var userToBeDisabled = await _userManager.FindByIdAsync(request.UserId) ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
            userToBeDisabled.IsDisabled = true;
            var result = await _userManager.UpdateAsync(userToBeDisabled);
            if (result.Succeeded)
            {
                return new DisableUserResponse();
            }
            throw new Exception(string.Join(". ", result.Errors.Select(p => p.Description)));
        }
        catch (Exception e)
        {
            _logger.LogError("Error when execute {} method.\nDate: {}.\nDetail: {}", nameof(this.DisableUserAsync),
                DateTime.UtcNow, e.Message);
            throw new Exception($"Error when execute {nameof(this.DisableUserAsync)} method");
        }
    }
    
    public async Task<UserInfoResponse> UpdateUserAsync(Guid userId, UpdateUserRequest request)
    {
        try
        {
            _logger.LogInformation("Updating user with ID: {UserId}", userId);
            var queryable = _userManager.Users;
            AppUser userToUpdate = await queryable.Where(q => q.Id == userId).Include(q => q.UserRoles).ThenInclude(q => q.Role).FirstOrDefaultAsync() ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
            userToUpdate.DateOfBirth = request.DateOfBirth;
            userToUpdate.JoinedDate = request.JoinedDate;
            
            
            userToUpdate.Gender = request.Gender;

            IList<String> currentRoles = await _userManager.GetRolesAsync(userToUpdate);
            if (!currentRoles.Contains(request.Role))
            {
                Role? updateRoles = await _roleManager.FindByNameAsync(request.Role);

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
        catch (Exception e)
        {
            _logger.LogError(e, "Error when executing {Method} method. Date: {Date}. Detail: {Detail}", nameof(this.UpdateUserAsync), DateTime.UtcNow, e.Message);

            throw new Exception(message: $"Error when executing {nameof(this.UpdateUserAsync)} method", e);
        }
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
        if (firstName.Split(' ').Length > Constants.NUMBER_OF_WORDS_IN_FIRSTNAME) throw new BadRequestException(ErrorStrings.INVALID_FIRSTNAME);
    }

    private void ValidateType(string type)
    {
        if (_roleManager.Roles.Where(r => r.Role.Name.Normalize() == type.Normalize()).FirstOrDefaultAsync() == null)
            throw new BadRequestException(ErrorStrings.INVALID_ROLE);
    }

    private void ValidateGender(string gender)
    {
        if (!Enum.IsDefined(typeof(Gender), gender)) throw new BadRequestException(ErrorStrings.INVALID_GENDER);
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

    private async Task<Location> GetAndValidateLocationAsync()
    {
        var currentAdminId = _contextAccessor.HttpContext?.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.ToString()
            ?? throw new UnauthorizedException(ErrorStrings.UNAUTHORIZED_USER);
        var adminUser = await _userManager.FindByIdAsync(currentAdminId) ?? throw new NotFoundException(ErrorStrings.USER_NOT_FOUND);
        if (adminUser.Location == null || Enum.TryParse(adminUser.Location, out Location location)) throw new Exception(ErrorStrings.INVALID_LOCATION);
        return location;
    }

    private void ValidateDateOfBirth(DateTime dateOfBirth)
    {
        var now = DateTime.Now;
        if (now < dateOfBirth || dateOfBirth.AddYears(Constants.MINIMUM_AGE) > now) throw new BadRequestException(ErrorStrings.INVALID_DATE_OF_BIRTH);
    }

    private void ValidateJoinedDate(DateTime dateOfBirth, DateTime joinedDate)
    {
        var now = DateTime.Now;
        if (now < joinedDate || dateOfBirth.AddYears(Constants.MINIMUM_AGE) > dateOfBirth)
            throw new BadRequestException(ErrorStrings.INVALID_JOINED_DATE);
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

