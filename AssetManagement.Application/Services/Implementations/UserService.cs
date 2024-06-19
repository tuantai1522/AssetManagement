using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AssetManagement.Application.Services.Implementations;
public class UserService : IUserService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ILogger<UserService> _logger;

    public UserService(UserManager<AppUser> userManager, ILogger<UserService> logger)
    {
        _userManager = userManager;
        _logger = logger;
    }

    public async Task<PagingDto<FilterUserDto>> FilterUserAsync(FilterUserRequestDto filter)
    {

        var queryable = _userManager.Users;

        //Need to get current user to get location 

        //var parameter = Expression.Parameter(typeof(AppUser));
        //Expression filterExpression = Expression.Constant(true); // default is "where true"

        //set default page size
        if (!filter.PageNumber.HasValue || !filter.PageSize.HasValue
            || filter.PageNumber.Value <= 0 || filter.PageSize.Value <= 0)
        {
            filter.PageNumber = 1;
            filter.PageSize = 5;
        }

        try
        {

            //if (!string.IsNullOrEmpty(filter.Name))
            //{
            //    var firstNameProperty = Expression.Property(parameter, nameof(AppUser.FirstName));
            //    var lastNameProperty = Expression.Property(parameter, nameof(AppUser.LastName));
            //    var staffCodeProperty = Expression.Property(parameter, nameof(AppUser.StaffCode));

            //    var concatenatedNames = Expression.Add(firstNameProperty, lastNameProperty, typeof(string).GetMethod("Concat", [typeof(string), typeof(string)]));

            //    var containsMethod = typeof(string).GetMethod(nameof(string.Contains), [typeof(string)])
            //                         ?? throw new NotSupportedException($"{nameof(string.Contains)} method is deprecated or not supported.");

            //    var containsExpression = Expression.Call(concatenatedNames, containsMethod, Expression.Constant(filter.Name));
            //    var statusCodeExpression = Expression.Equal(staffCodeProperty, Expression.Constant(filter.Name));

            //    filterExpression = Expression.AndAlso(filterExpression, containsExpression);
            //    filterExpression = Expression.Or(filterExpression, statusCodeExpression);

            //}

            //if (filter.Types != null && filter.Types.Any())
            //{
            //    Expression<Func<AppUser, bool>> abc = user => user.Roles.Contains()
            //}

            var orderBy = GetOrderByExpression(filter);

            //var userSpecification = Expression.Lambda<Func<AppUser, bool>>(filterExpression, parameter);

            Expression<Func<AppUser, bool>> filterSpecification = u => (string.IsNullOrEmpty(filter.Name) || (u.FirstName + u.LastName).Contains(filter.Name))
            && (filter.Types == null || !filter.Types.Any() || filter.Types.Contains(u.UserRoles.Select(ur => ur.Role.Name).FirstOrDefault()));

            var totalRecord = await queryable.CountAsync();

            queryable = orderBy(queryable);

            var result = await queryable
                .AsNoTracking()
                .Where(filterSpecification)
                .Skip((filter.PageNumber.Value - 1) * filter.PageSize.Value)
                .Take(filter.PageSize.Value)
                .Select(u => new FilterUserDto()
                {
                    Id = u.Id,
                    FullName = $"{u.FirstName} {u.LastName}",
                    JoinedDate = u.JoinedDate,
                    StaffCode = u.StaffCode,
                    Username = u.UserName,
                    Types = u.UserRoles.Select(ur => ur.Role.Name).ToList()
                }).ToListAsync();

            var totalPages = (int)Math.Ceiling((double)totalRecord / filter.PageSize.Value);
            return new PagingDto<FilterUserDto>()
            {
                CurrentPage = filter.PageNumber.Value,
                TotalItemCount = totalRecord,
                PageSize = filter.PageSize.Value,
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

    private Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>> GetOrderByExpression(FilterUserRequestDto filter)
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
}

