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
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

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
                Specification = u.Specification,
                InstalledDate = u.InstalledDate,
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
        public async Task<AssetResponse> CreateAssetAsync(AssetCreationRequest request)
        {
            var userLogin = await GetUserLogined();
            var category = await GetCategoryOfAsset(request.CategoryId);

            var newAsset = _mapper.Map<Asset>(request);
            newAsset.AssetCode = await GenerateAssetCode(category);
            newAsset.Location = userLogin.Location;
            newAsset.CreatedAt = DateTime.Now;
            newAsset.LastUpdated = DateTime.Now;

            _unitOfWork.AssetRepository.Add(newAsset);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<AssetResponse>(newAsset);
        }

        public async Task UpdateAssetAsync(AssetUpdateRequest request)
        {
            var assetToUpdate = await GetAsset(request.AssetId);

            if (assetToUpdate.State != AssetState.Available)
                throw new BadRequestException("Can't edit asset whose state is not Available");

            if (request.InstalledDate > DateTime.Now)
                throw new BadRequestException("Can not select and input future date");

            var userLogin = await GetUserLogined();

            CheckAssetBelongsToLocationOfUser(userLogin, assetToUpdate);

            assetToUpdate.Name = request.AssetName;
            assetToUpdate.Specification = request.Specification;
            assetToUpdate.InstalledDate = request.InstalledDate;
            assetToUpdate.State = request.State!.Value;
            assetToUpdate.LastUpdated = DateTime.Now;

            _unitOfWork.AssetRepository.Update(assetToUpdate);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAssetAsync(Guid Id)
        {
            var assetToDelete = await GetAsset(Id);

            //Can't delete asset which have state is Assigned
            if (assetToDelete.State == AssetState.Assigned)
                throw new BadRequestException("Can't delete asset which have state is assigned");

            //Can't delete asset which belongs to one or more historical assignments
            if (assetToDelete.HasAssignments)
                throw new BadRequestException("Can't delete asset which belongs to one or more historical assignments");

            var userLogin = await GetUserLogined();

            CheckAssetBelongsToLocationOfUser(userLogin, assetToDelete);

            _unitOfWork.AssetRepository.Delete(assetToDelete.Id);
            await _unitOfWork.SaveChangesAsync();

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
                { SortState: SortOption.Asc } => q => q.OrderBy(a => a.State == AssetState.Assigned ? 0 : a.State == AssetState.Available ? 1 : a.State == AssetState.NotAvailable ? 2 : a.State == AssetState.Recycled ? 3 : 4),
                { SortState: SortOption.Desc } => q => q.OrderByDescending(a => a.State == AssetState.Assigned ? 0 : a.State == AssetState.Available ? 1 : a.State == AssetState.NotAvailable ? 2 : a.State == AssetState.Recycled ? 3 : 4),
                { SortLastUpdate: SortOption.Asc } => q => q.OrderBy(a => a.LastUpdated),
                { SortLastUpdate: SortOption.Desc } => q => q.OrderByDescending(a => a.LastUpdated),
                _ => q => q.OrderBy(a => a.Name)
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
                filterSpecification = filterSpecification.And(a => filter.States.Any(s => s == a.State));
            }

            if (filter.Categories != null && filter.Categories.Length > 0)
            {
                filterSpecification = filterSpecification.And(a => a.Category != null && filter.Categories.Contains(a.Category.Name));
            }
            return filterSpecification;
        }
        private async Task<string> GenerateAssetCode(Category category)
        {
            var lastAssetCode = await _unitOfWork.AssetRepository.GetQueryableSet().Where(a => a.CategoryId.Equals(category.Id)).OrderByDescending(a => a.AssetCode).FirstOrDefaultAsync();
            string assetCode = "";
            if (lastAssetCode != null && lastAssetCode.AssetCode != null)
            {
                string numberStr = Regex.Match(lastAssetCode.AssetCode, @"\d+").Value;
                assetCode = string.Concat(category.Prefix, (int.Parse(numberStr) + 1).ToString().PadLeft(6, '0'));
            }
            else
            {
                assetCode = string.Concat(category.Prefix, "1".PadLeft(6, '0'));
            }

            return assetCode;
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
        private async Task<Category> GetCategoryOfAsset(Guid categoryId)
        {
            var category = await _unitOfWork.CategoryRepository.FindOne(c => c.Id.Equals(categoryId));
            if (category == null)
            {
                throw new NotFoundException("Category is not found!");
            }
            return category;
        }
        private async Task<Asset> GetAsset(Guid assetId)
        {
            var asset = await _unitOfWork.AssetRepository
                            .GetQueryableSet()
                            .Where(a => a.Id.Equals(assetId))
                            .Include(x => x.Assignments)
                            .Include(x => x.Category)
                            .FirstOrDefaultAsync();

            if (asset == null)
                throw new NotFoundException("Can't find asset");

            return asset;
        }

        private void CheckAssetBelongsToLocationOfUser(AppUser user, Asset asset)
        {
            if (!user.Location!.Equals(asset.Location))
                throw new BadRequestException("This asset doesn't belong to this user");
        }


        #endregion
    }

}
