using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Common.Constants;
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
using AssetManagement.Domain.Exceptions;

namespace AssetManagement.Application.Services.Implementations
{
    public class ReturningRequestService : IReturningRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUser _currentUser;
        private readonly UserManager<AppUser> _userManager;
        private readonly ILogger<ReturningRequestService> _logger;

        public ReturningRequestService(IUnitOfWork unitOfWork, ICurrentUser currentUser, UserManager<AppUser> userManager, ILogger<ReturningRequestService> logger)
        {
            _unitOfWork = unitOfWork;
            _currentUser = currentUser;
            _userManager = userManager;
            _logger = logger;
        }

        public async Task CompleteReturnRequestByIdAsync(Guid requestId)
        {
            _logger.LogInformation("*********************CompleteReturnRequestByIdAsync*********************");
            var currentUser = await _userManager.Users
                .Where(u => _currentUser.UserId.Equals(u.Id))
                .Select(u => new AppUser()
                {
                    Id = u.Id,
                    Location = u.Location,
                })
                .FirstOrDefaultAsync();

            //Validation
            var request = await _unitOfWork.ReturningRequestRepository.GetRequestByIdAsync(requestId);
            if (request == null)
            {
                _logger.LogWarning("Returning request not found for request ID: {RequestId}", requestId);
                throw new NotFoundException(ErrorStrings.REQUEST_NOT_FOUND);
            }
            if (request.Assignment.Asset!.Location != currentUser!.Location)
            {
                _logger.LogWarning("Invalid location for asset ID: {AssetId}. Expected: {ExpectedLocation}, Actual: {ActualLocation}",
                    request.Assignment.Asset.Id, currentUser.Location, request.Assignment.Asset.Location);
                throw new BadRequestException(ErrorStrings.INVALID_LOCATION);
            }
            if (request.State != ReturningRequestState.WaitingForReturning)
            {
                _logger.LogWarning("Invalid state for returning request ID: {RequestId}. Expected: {ExpectedState}, Actual: {ActualState}",
                    requestId, ReturningRequestState.WaitingForReturning, request.State);
                throw new BadRequestException(ErrorStrings.INVALID_REQUEST_STATE);
            }
            request.State = ReturningRequestState.Completed;
            request.ReturnedDate = DateTime.Now;
            request.Assignment.State = AssignmentState.Returned;
            request.Assignment.Asset.State = AssetState.Available;
            request.AcceptedByUserId = currentUser.Id;
            await _unitOfWork.SaveChangesAsync();
            return;
        }
        public async Task<PagingDto<FilterReturningResponse>> FilterReturningAsync(FilterReturningRequest filter)
        {
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

            if (currentUser.IsDisabled)
            {
                if (currentUser.IsDisabled)
                {
                    throw new UnauthorizedAccessException(ErrorStrings.USER_IS_DISABLED);
                }

                var queryable = _unitOfWork.ReturningRequestRepository.GetQueryableSet();
                //set default page size
                if (!filter.PageNumber.HasValue || !filter.PageSize.HasValue
                    || filter.PageNumber.Value <= 0 || filter.PageSize.Value <= 0)
                {
                || filter.PageNumber.Value <= 0 || filter.PageSize.Value <= 0)
            {
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

                public async Task CreateRequestByAdminAsync(Guid assignmentId)
                {
                    var assignment = await GetAssignment(assignmentId);
                    var user = await GetUserLogined();

                    // To check whether this assignment belongs to location of user or not
                    if (!assignment.AssignedByUser!.Location!.Equals(user.Location))
                        throw new BadRequestException("Location of this assignment is different from location of current user");

                    await CreateRequestByAccountAsync(assignment, user);

                }

                #region Private methods
                private Expression<Func<ReturningRequest, bool>> GetSpecification(FilterReturningRequest filter, AppUser currentUser)
                {
                    Expression<Func<ReturningRequest, bool>> filterSpecification = PredicateBuilder.True<ReturningRequest>();
                    filterSpecification = filterSpecification.And(a => a.Assignment != null && a.Assignment.Asset != null && a.Assignment.Asset.Location == currentUser.Location);

                    if (!string.IsNullOrWhiteSpace(filter.Search))
                    {
                        filterSpecification = filterSpecification.And(
                            r => (r.Assignment != null && r.Assignment.Asset != null && r.Assignment.Asset.Name != null && r.Assignment.Asset.Name.ToLower().Contains(filter.Search.Trim().ToLower()))
                            || (r.Assignment != null && r.Assignment.Asset != null && r.Assignment.Asset.AssetCode != null && r.Assignment.Asset.AssetCode.ToLower().Contains(filter.Search.Trim().ToLower()))
                            || (r.RequestedByUser != null && r.RequestedByUser.UserName != null && r.RequestedByUser.UserName.ToLower().Contains(filter.Search.Trim().ToLower())));
                    }

                    if (filter.States != null && filter.States.Length > 0)
                    {
                        filterSpecification = filterSpecification.And(r => filter.States.Any(s => s == r.State));
                    }

                    if (filter.ReturnedDate.HasValue)
                    {
                        filterSpecification = filterSpecification.And(r => r.ReturnedDate.HasValue && r.ReturnedDate.Value.Date == filter.ReturnedDate.Value.Date);
                    }
                    return filterSpecification;
                }


                private Func<IQueryable<ReturningRequest>, IOrderedQueryable<ReturningRequest>> GetOrderBy(FilterReturningRequest filter)
                {
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

                private async Task CreateRequestByAccountAsync(Assignment assignment, AppUser user)
                {
                    // To check whether this assignment has state "Accepted" or not
                    if (assignment.State != AssignmentState.Accepted)
                        throw new BadRequestException("Can't create request with assignment's state is not Accepted");

                    assignment.State = AssignmentState.WaitingForReturning;

                    var requestReturning = new ReturningRequest
                    {
                        AssignmentId = assignment.Id,
                        RequestedByUserId = user.Id,
                    };

                    _unitOfWork.ReturningRequestRepository.Add(requestReturning);

                    await _unitOfWork.SaveChangesAsync();
                }

                private async Task<Assignment> GetAssignment(Guid assignmentId)
                {
                    var assignment = await _unitOfWork.AssignmentRepository
                                    .GetQueryableSet()
                                    .Where(a => a.Id.Equals(assignmentId))
                                    .Include(x => x.Asset)
                                    .Include(x => x.AssignedToUser)
                                    .Include(x => x.AssignedByUser)
                                    .FirstOrDefaultAsync() ?? throw new NotFoundException("Can't find assignment");

                    return assignment;
                }
                private async Task<AppUser> GetUserLogined()
                {
                    var userLogin = await _userManager.FindByIdAsync(_currentUser.UserId.ToString());
                    if (userLogin == null)
                    {
                        throw new NotFoundException("User is not found!");
                    }
                    else if (userLogin.IsDisabled)
                    {
                        throw new BadRequestException("Your account is disabled!");
                    }
                    return userLogin;
                }


                #endregion
            }
        }
