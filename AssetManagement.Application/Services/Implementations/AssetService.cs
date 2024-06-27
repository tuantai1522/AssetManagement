using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Application.Services.Implementations
{
    public class AssetService : IAssetService
    {
        private readonly ICurrentUser _currentUser;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AssetService(ICurrentUser currentUser, IMapper mapper, IUnitOfWork unitOfWork, UserManager<AppUser> userManager)
        {
            _currentUser = currentUser;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<AssetDetailsResponse> GetAssetByIdAsync(AssetDetailsRequest request)
        {
            if (request.Id.Equals(Guid.Empty))
                throw new BadRequestException("Please provide id to get asset");

            var asset = _unitOfWork.AssetRepo
                            .Get(x => x.Id.Equals(request.Id), orderBy: null, includeProperties: "Category")
                            .FirstOrDefault()
                ?? throw new NotFoundException("Can't find asset");

            var userLogin = await _userManager.FindByIdAsync(_currentUser.UserId.ToString())
                ?? throw new NotFoundException("Can't find user");

            if (!userLogin.Location!.Equals(asset.Location))
                throw new UnauthorizedException("This user can't view this asset");

            return _mapper.Map<AssetDetailsResponse>(asset);

        }

        public async Task UpdateAssetAsync(AssetUpdateRequest request)
        {
            if (request.AssetId.Equals(Guid.Empty))
                throw new BadRequestException("Please provide id to update asset");

            if (string.IsNullOrEmpty(request.AssetName) ||
               string.IsNullOrEmpty(request.State) ||
               string.IsNullOrEmpty(request.Specification) ||
               !request.InstalledDate.HasValue)
                throw new BadRequestException("Please provide full info to update asset");


            var assetToUpdate = _unitOfWork.AssetRepo
                .Get(x => x.Id.Equals(request.AssetId), orderBy: null, includeProperties: "Category")
                .FirstOrDefault()
                ?? throw new NotFoundException("Can't find asset");

            var userLogin = await _userManager.FindByIdAsync(_currentUser.UserId.ToString())
                ?? throw new NotFoundException("Can't find user to update");

            if (!userLogin.Location!.Equals(assetToUpdate.Location) || userLogin.IsDisabled)
                throw new UnauthorizedException("This user can't update this asset");

            assetToUpdate.Name = request.AssetName;
            assetToUpdate.Specification = request.Specification;
            assetToUpdate.InstalledDate = request.InstalledDate;
            assetToUpdate.State = request.State;

            _unitOfWork.AssetRepo.Update(assetToUpdate);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}
