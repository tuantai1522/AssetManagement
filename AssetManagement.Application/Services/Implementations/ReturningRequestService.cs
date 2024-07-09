﻿using AssetManagement.Application.Common.Constants;
using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Common.ExpressionBuilder;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Requests;
using AssetManagement.Contracts.Dtos.ReturningRequestDtos.Responses;
using AssetManagement.Contracts.Enums;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AssetManagement.Application.Services.Implementations {
    public class ReturningRequestService : IReturningRequestService {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<AppUser> _userManager;
        private readonly ICurrentUser _currentUser;

        public ReturningRequestService(IUnitOfWork unitOfWork, UserManager<AppUser> userManager, ICurrentUser currentUser) {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _currentUser = currentUser;
        }

        public async Task<PagingDto<FilterReturningResponse>> FilterReturningAsync(FilterReturningRequest filter) {
            var currentUser = await _userManager.Users
                .Where(u => _currentUser.UserId.Equals(u.Id))
                .Select(u => new AppUser()
                {
                    Id = u.Id,
                    IsDisabled = u.IsDisabled,
                    Location = u.Location,
                })
                .FirstOrDefaultAsync()
                .ContinueWith(t => t.Result ?? throw new UnauthorizedAccessException(ErrorStrings.USER_NOT_LOGIN));

            if (currentUser.IsDisabled) {
                throw new UnauthorizedAccessException(ErrorStrings.USER_IS_DISABLED);
            }

            var queryable = _unitOfWork.ReturningRequestRepository.GetQueryableSet();
            //set default page size
            if (!filter.PageNumber.HasValue || !filter.PageSize.HasValue
                || filter.PageNumber.Value <= 0 || filter.PageSize.Value <= 0) {
                filter.PageNumber = 1;
                filter.PageSize = 5;
            }
            var filterSpecification = GetSpecification(filter, currentUser);
            var filteredQueryable = queryable.Where(filterSpecification);

            var orderBy = GetOrderBy(filter);
            var finalQueryable = orderBy(filteredQueryable);

            var result = await finalQueryable
            .AsNoTracking()
            .Skip((filter.PageNumber.Value - 1) * filter.PageSize.Value)
            .Take(filter.PageSize.Value)
            .Select(a => new FilterReturningResponse()
            {
                Id = a.Id,
                AssetCode = a.Assignment != null ? (a.Assignment.Asset != null ? a.Assignment.Asset.AssetCode : null) : null,
                AssetName = a.Assignment != null ? (a.Assignment.Asset != null ? a.Assignment.Asset.Name : null) : null,
                RequestedBy = a.RequestedByUser != null ? a.RequestedByUser.UserName : null,
                AcceptedBy = a.AcceptedByUser != null ? a.AcceptedByUser!.UserName : null,
                AssignedDate = a.Assignment != null ? a.Assignment.AssignedDate : null,
                ReturnedDate = a.ReturnedDate,
                State = a.State
            }).ToListAsync();

            int totalRecord = await filteredQueryable.CountAsync();

            return new PagingDto<FilterReturningResponse>()
            {
                CurrentPage = filter.PageNumber.Value,
                TotalItemCount = totalRecord,
                PageSize = filter.PageSize.Value,
                Data = result
            };
        }

        #region Private methods
        private Expression<Func<ReturningRequest, bool>> GetSpecification(FilterReturningRequest filter, AppUser currentUser) {
            Expression<Func<ReturningRequest, bool>> filterSpecification = PredicateBuilder.True<ReturningRequest>();
            filterSpecification = filterSpecification.And(a => a.Assignment != null && a.Assignment.Asset != null && a.Assignment.Asset.Location == currentUser.Location);

            if (!string.IsNullOrWhiteSpace(filter.Search)) {
                filterSpecification = filterSpecification.And(
                    r => (r.Assignment != null && r.Assignment.Asset != null && r.Assignment.Asset.Name != null && r.Assignment.Asset.Name.ToLower().Contains(filter.Search.Trim().ToLower()))
                    || (r.Assignment != null && r.Assignment.Asset != null && r.Assignment.Asset.AssetCode != null && r.Assignment.Asset.AssetCode.ToLower().Contains(filter.Search.Trim().ToLower()))
                    || (r.RequestedByUser != null && r.RequestedByUser.UserName != null && r.RequestedByUser.UserName.ToLower().Contains(filter.Search.Trim().ToLower())));
            }

            if (filter.States != null && filter.States.Length > 0) {
                filterSpecification = filterSpecification.And(r => filter.States.Any(s => s == r.State));
            }

            if (filter.ReturnedDate.HasValue) {
                filterSpecification = filterSpecification.And(r => r.ReturnedDate.HasValue && r.ReturnedDate.Value.Date == filter.ReturnedDate.Value.Date);
            }
            return filterSpecification;
        }


        private Func<IQueryable<ReturningRequest>, IOrderedQueryable<ReturningRequest>> GetOrderBy(FilterReturningRequest filter) {
            return filter switch
            {
                { SortAssetCode: SortOption.Asc } => q => q.OrderBy(r => r.Assignment.Asset!.AssetCode),
                { SortAssetCode: SortOption.Desc } => q => q.OrderByDescending(r => r.Assignment.Asset!.AssetCode),
                { SortAssetName: SortOption.Asc } => q => q.OrderBy(r => r.Assignment.Asset!.Name),
                { SortAssetName: SortOption.Desc } => q => q.OrderByDescending(r => r.Assignment.Asset!.Name),
                { SortRequestedBy: SortOption.Asc } => q => q.OrderBy(r => r.RequestedByUser == null ? null : r.RequestedByUser.UserName),
                { SortRequestedBy: SortOption.Desc } => q => q.OrderByDescending(r => r.RequestedByUser == null ? null : r.RequestedByUser.UserName),
                { SortAssignedDate: SortOption.Asc } => q => q.OrderBy(r => r.Assignment.AssignedDate),
                { SortAssignedDate: SortOption.Desc } => q => q.OrderByDescending(r => r.Assignment.AssignedDate),
                { SortAcceptedBy: SortOption.Asc } => q => q.OrderBy(r => r.AcceptedByUser == null ? null : r.AcceptedByUser!.UserName),
                { SortAcceptedBy: SortOption.Desc } => q => q.OrderByDescending(r => r.AcceptedByUser == null ? null : r.AcceptedByUser!.UserName),
                { SortReturnedDate: SortOption.Asc } => q => q.OrderBy(a => a.ReturnedDate),
                { SortReturnedDate: SortOption.Desc } => q => q.OrderByDescending(a => a.ReturnedDate),
                { SortState: SortOption.Asc } => q => q.OrderBy(a =>
                a.State == ReturningRequestState.Completed ? 0
                : (a.State == ReturningRequestState.WaitingForReturning ? 1 : 2)),
                { SortState: SortOption.Desc } => q => q.OrderByDescending(a =>
                a.State == ReturningRequestState.Completed ? 0
                : (a.State == ReturningRequestState.WaitingForReturning ? 1 : 2)),
                _ => q => q.OrderByDescending(a => a.ReturnedDate)
            };
        }
        #endregion
    }
}
