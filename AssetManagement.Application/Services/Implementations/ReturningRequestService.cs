using AssetManagement.Application.Common.Constants;
using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace AssetManagement.Application.Services.Implementations {
    public class ReturningRequestService : IReturningRequestService {
        private readonly IUnitOfWork _unitOfWork;
		private readonly ICurrentUser _currentUser;
		private readonly UserManager<AppUser> _userManager;
		private readonly ILogger<ReturningRequestService> _logger;

        public ReturningRequestService(IUnitOfWork unitOfWork, ICurrentUser currentUser, UserManager<AppUser> userManager, ILogger<ReturningRequestService> logger) {
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
			if (request.Assignment is null)
			{
				_logger.LogWarning("Returning request not found for request ID: {RequestId}", requestId);
				throw new NotFoundException(ErrorStrings.ASSIGNMENT_NOT_FOUND);
			}
			if (request.Assignment.Asset is null)
			{
				_logger.LogWarning("Asset not found for assignment ID: {AssignmentId}", request.Assignment.Id);
				throw new NotFoundException(ErrorStrings.ASSET_NOT_FOUND);
			}
			if (request.Assignment.Asset.Location != currentUser!.Location)
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
	}
}
