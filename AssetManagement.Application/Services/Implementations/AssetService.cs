using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Dtos.AssetDtos.Responses;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

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

        public async Task<AssetResponse> CreateAssetAsync(AssetCreationRequest request)
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

            var category = await _unitOfWork.CategoryRepo.FindOne(c => c.Id.Equals(request.CategoryId));
            if (category == null)
            {
                throw new NotFoundException("Category is not found!");
            }
            var newAsset = _mapper.Map<Asset>(request);
            newAsset.AssetCode = await GenerateAssetCode(category);
            newAsset.Location = userLogin.Location;
            newAsset.CreatedAt = DateTime.Now;
            newAsset.LastUpdated = DateTime.Now;

            _unitOfWork.AssetRepo.Add(newAsset);
            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<AssetResponse>(newAsset);
        }

        private async Task<string> GenerateAssetCode(Category category)
        {
            var lastAssetCode = await _unitOfWork.AssetRepo.GetQueryableSet().Where(a => a.CategoryId.Equals(category.Id)).OrderByDescending(a => a.AssetCode).FirstOrDefaultAsync();
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
    }
}
