using AssetManagement.Application.Common.Constants;
using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Common.ExpressionBuilder;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.PaginationDtos;
using AssetManagement.Contracts.Enums;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AssetManagement.Application.Services.Implementations
{
    public class AssetService : IAssetService
    {
        private readonly ILogger<AssetService> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUser _currentUser;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        public AssetService(ILogger<AssetService> logger, IUnitOfWork unitOfWork, ICurrentUser currentUser, IMapper mapper, UserManager<AppUser> userManager)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _currentUser = currentUser;
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<PagingDto<FilterAssetResponse>> FilterAssetAsync(FilterAssetRequest filter)
        {
            _logger.LogInformation("*********************Filter Asset*********************");
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
                throw new UnauthorizedAccessException(ErrorStrings.USER_IS_DISABLED);
            }

            var queryable = _unitOfWork.AssetRepository.GetQueryableSet().Include(q => q.Category);
            //set default page size
            if (!filter.PageNumber.HasValue || !filter.PageSize.HasValue
                || filter.PageNumber.Value <= 0 || filter.PageSize.Value <= 0)
            {
                filter.PageNumber = 1;
                filter.PageSize = 5;
            }
            var filterSpecification = GetFilterSpecification(filter, currentUser);
            var filteredQueryable = queryable.Where(filterSpecification);

            var orderBy = GetOrderByFunction(filter);
            var finalQueryable = orderBy(filteredQueryable);

            var result = await finalQueryable
            .AsNoTracking()
            .Skip((filter.PageNumber.Value - 1) * filter.PageSize.Value)
            .Take(filter.PageSize.Value)
            .Select(u => new FilterAssetResponse()
            {
                Id = u.Id,
                AssetCode = u.AssetCode,
                Name = u.Name,
                Category = u.Category != null ? u.Category.Name : string.Empty,
                State = u.State,
            }).ToListAsync();

            int totalRecord = await filteredQueryable.CountAsync();

            return new PagingDto<FilterAssetResponse>()
            {
                CurrentPage = filter.PageNumber.Value,
                TotalItemCount = totalRecord,
                PageSize = filter.PageSize.Value,
                Data = result
            };
        }

        public async Task<AssetDetailsResponse> GetAssetByIdAsync(AssetDetailsRequest request)
        {
            if (request.Id.Equals(Guid.Empty))
                throw new BadRequestException("Please provide id to get asset");

            var asset = _unitOfWork.AssetRepository
                            .Get(x => x.Id.Equals(request.Id), orderBy: null, includeProperties: "Category")
                            .FirstOrDefault()
                ?? throw new NotFoundException("Can't find asset");

            var userLogin = await _userManager.FindByIdAsync(_currentUser.UserId.ToString())
                ?? throw new NotFoundException("Can't find user");

            if (!userLogin.Location!.Equals(asset.Location))
                throw new UnauthorizedException("This user can't view this asset");

            return _mapper.Map<AssetDetailsResponse>(asset);
        }

        public async Task<AssetDetailsResponse> GetAssetByIdAsync(AssetDetailsRequest request)
        {
            if (request.Id.Equals(Guid.Empty))
                throw new BadRequestException("Please provide id to get asset");

            var asset = _unitOfWork.AssetRepository
                            .Get(x => x.Id.Equals(request.Id), orderBy: null, includeProperties: "Category")
                            .FirstOrDefault()
                ?? throw new NotFoundException("Can't find asset");

            var userLogin = await _userManager.FindByIdAsync(_currentUser.UserId.ToString())
                ?? throw new NotFoundException("Can't find user");

            if (!userLogin.Location!.Equals(asset.Location))
                throw new UnauthorizedException("This user can't view this asset");

            return _mapper.Map<AssetDetailsResponse>(asset);
        }

        #region Private methods
        private Func<IQueryable<Asset>, IOrderedQueryable<Asset>> GetOrderByFunction(FilterAssetRequest filter)
        {
            return filter switch
            {
                { SortAssetCode: SortOption.Asc } => q => q.OrderBy(a => a.AssetCode),
                { SortAssetCode: SortOption.Desc } => q => q.OrderByDescending(a => a.AssetCode),
                { SortAssetName: SortOption.Asc } => q => q.OrderBy(a => a.Name),
                { SortAssetName: SortOption.Desc } => q => q.OrderByDescending(a => a.Name),
                { SortCategory: SortOption.Asc } => q => q.OrderBy(a => a.Category!.Name),
                { SortCategory: SortOption.Desc } => q => q.OrderByDescending(a => a.Category!.Name),
                { SortState: SortOption.Asc } => q => q.OrderBy(a => a.State),
                { SortState: SortOption.Desc } => q => q.OrderByDescending(a => a.State),
                { SortLastUpdate: SortOption.Asc } => q => q.OrderBy(a => a.LastUpdated),
                { SortLastUpdate: SortOption.Desc } => q => q.OrderByDescending(a => a.LastUpdated),
                _ => q => q.OrderBy(a => a.AssetCode)
            };
        }
        private Expression<Func<Asset, bool>> GetFilterSpecification(FilterAssetRequest filter, AppUser currentUser)
        {
            Expression<Func<Asset, bool>> filterSpecification = PredicateBuilder.True<Asset>();
            filterSpecification = filterSpecification.And(a => a.Location == currentUser.Location);

            if (!string.IsNullOrWhiteSpace(filter.Search))
            {
                filterSpecification = filterSpecification.And(
                    a => (a.Name != null && a.Name.ToLower().Contains(filter.Search.ToLower()))
                    || (a.AssetCode != null && a.AssetCode.ToLower().Contains(filter.Search.ToLower())));
            }

            if (filter.States != null && filter.States.Length > 0)
            {
                filterSpecification = filterSpecification.And(a => filter.States.Where(s => s == a.State).Any());
            }

            if (filter.Categories != null && filter.Categories.Length > 0)
            {
                filterSpecification = filterSpecification.And(a => a.Category != null && filter.Categories.Contains(a.Category.Name));
            }
            return filterSpecification;
        }

        #endregion
    }

}
