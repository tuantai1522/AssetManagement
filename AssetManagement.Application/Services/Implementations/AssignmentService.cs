using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Application.Services.Implementations
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUser _currentUser;
        private readonly UserManager<AppUser> _userManager;

        public AssignmentService(ICurrentUser currentUser, IUnitOfWork unitOfWork, UserManager<AppUser> userManager)
        {
            _currentUser = currentUser;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }

        public async Task<Guid> CreateAssignmentAsync(AssignmentCreationRequest request)
        {
            await ValidateCurrentUserLogined();
            var userAssignedTo = await GetUserAssignedById(request.UserId);

            var asset = await GetAssetById(request.AssetId);

            var newAssignment = new Assignment
            {
                Id = Guid.NewGuid(),
                AssetId = asset.Id,
                AssignedById = _currentUser.UserId,
                AssignedToId = userAssignedTo.Id,
                Note = request.Note,
                AssignedDate = request.AssignedDate,
                State = AssignmentState.WaitingForAcceptance,
            };

            _unitOfWork.AssignmentRepository.Add(newAssignment);

            //Update state of asset
            asset.State = AssetState.NotAvailable;
            _unitOfWork.AssetRepository.Update(asset);

            await _unitOfWork.SaveChangesAsync();
            return newAssignment.Id;
        }

        private async Task<AppUser> GetUserAssignedById(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                throw new NotFoundException("User to assigned is not found!");
            }
            else if (user.IsDisabled)
            {
                throw new BadRequestException("User to assigned is disabled!");
            }
            return user;
        }

        private async Task<Asset> GetAssetById(Guid assetId)
        {
            var asset = await _unitOfWork.AssetRepository.FindOne(a => a.Id.Equals(assetId));
            if (asset == null)
            {
                throw new NotFoundException("Asset to assigned is not found!");
            }
            else if (AssetState.Available != asset.State)
            {
                throw new BadRequestException("Asset is not available to assigned!");
            }
            return asset;
        }

        private async Task ValidateCurrentUserLogined()
        {
            if (_currentUser != null)
            {
                var currentUser = await _userManager.FindByIdAsync(_currentUser.UserId.ToString());
                if (currentUser == null)
                {
                    throw new UnauthorizedException("User logined is not found!");
                }
                else if (currentUser.IsDisabled)
                {
                    throw new UnauthorizedException("Your account is disabled!");
                }
            }
        }

    }
}