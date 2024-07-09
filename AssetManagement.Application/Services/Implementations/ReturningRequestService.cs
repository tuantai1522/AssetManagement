using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Application.Services.Implementations
{
    public class ReturningRequestService : IReturningRequestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICurrentUser _currentUser;

        private readonly UserManager<AppUser> _userManager;



        public ReturningRequestService(IUnitOfWork unitOfWork, ICurrentUser currentUser, UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _currentUser = currentUser;
            _userManager = userManager;
        }

        public async Task CreateRequestByUserAsync(Guid assignmentId)
        {
            var assignment = await GetAssignment(assignmentId);
            var user = await GetUserLogined();

            // To check whether this assignment belongs to this user or not
            if (assignment.AssignedToUser!.Equals(user.Id))
                throw new NotFoundException("This assignment doesn't belong to this user");

            // To check whether this assignment has state "Accepted" or not
            if (assignment.State != AssignmentState.Accepted)
                throw new BadRequestException("Can't create request with assignment's state is not Accepted");


            assignment.State = AssignmentState.WaitingForReturning;

            var requestReturning = new ReturningRequest
            {
                State = ReturningRequestState.WaitingForReturning,
                AssignmentId = assignmentId,
                AcceptedByUserId = user.Id,
            };

            _unitOfWork.ReturningRequestRepository.Add(requestReturning);

            await _unitOfWork.SaveChangesAsync();
        }

        #region Private methods

        private async Task CreateRequestByAccountAsync(Guid assignmentId)
        {
            var assignment = await GetAssignment(assignmentId);
            var user = await GetUserLogined();

            // To check whether this assignment belongs to this user or not
            if (assignment.AssignedToUser!.Equals(user.Id))
                throw new NotFoundException("This assignment doesn't belong to this user");

            // To check whether this assignment has state "Accepted" or not
            if (assignment.State != AssignmentState.Accepted)
                throw new BadRequestException("Can't create request with assignment's state is not Accepted");


            assignment.State = AssignmentState.WaitingForReturning;

            var requestReturning = new ReturningRequest
            {
                State = ReturningRequestState.WaitingForReturning,
                AssignmentId = assignmentId,
                AcceptedByUserId = user.Id,
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
