using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Application.Services.Implementations
{
    public class AssetService : IAssetService
    {
        private readonly ICurrentUser _currentUser;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<AppUser> _userManager;


        public AssetService(ICurrentUser currentUser, IMapper mapper, IUnitOfWork unitOfWork, UserManager<AppUser> userManager)
        {
            _currentUser = currentUser;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<AssetDetailsResponse> GetAssetByIdAsync(AssetDetailsRequest request)
        {
            if (string.IsNullOrEmpty(request.Id.ToString()))
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
    }
}
