using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using Microsoft.Identity.Client;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests.Services.ReturningRequestTests
{
	public class CompleteReturnRequestByIdAsyncTest : SetupReturningRequestServiceTest
	{
		public CompleteReturnRequestByIdAsyncTest() : base() { }
		[Fact]
		public async Task CompleteReturnRequestByIdAsync_ReturningRequestNotFound_ThrowsNotFoundException()
		{
			// Arrange
			var userId = _users[0].Id;
			_currentUserMock.Setup(c => c.UserId).Returns(userId);

			_userManagerMock.Setup(x => x.Users).Returns(_users.AsQueryable().BuildMockDbSet().Object);

			_unitOfWorkMock.Setup(u => u.ReturningRequestRepository.GetRequestByIdAsync(It.IsAny<Guid>()))
							 .ReturnsAsync((ReturningRequest)null!);

			// Act & Assert
			await Assert.ThrowsAsync<NotFoundException>(() => _returningRequestService.CompleteReturnRequestByIdAsync(Guid.NewGuid()));
		}
		[Fact]
		public async Task CompleteReturnRequestByIdAsync_InvalidLocation_ThrowsBadRequestException()
		{
			//Arrange
			var userId = _users[0].Id;
			_currentUserMock.Setup(c => c.UserId).Returns(userId);

			_userManagerMock.Setup(u => u.Users).Returns(_users.AsQueryable().BuildMockDbSet().Object);

			var request = _returningRequests[0];
			request.Assignment.Asset!.Location = "Different Location";

			_unitOfWorkMock.Setup(uow => uow.ReturningRequestRepository.GetRequestByIdAsync(It.IsAny<Guid>()))
				.ReturnsAsync(request);
			//Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => _returningRequestService.CompleteReturnRequestByIdAsync(Guid.NewGuid()));
		}
		[Fact]
		public async Task CompleteReturnRequestByIdAsync_InvalidRequestState_ThrowsBadRequestException()
		{
			// Arrange
			var userId = _users[0].Id;
			_currentUserMock.Setup(c => c.UserId).Returns(userId);

			_userManagerMock.Setup(x => x.Users).Returns(_users.AsQueryable().BuildMockDbSet().Object);

			var request = _returningRequests[0];
			request.State = ReturningRequestState.Completed;

			_unitOfWorkMock.Setup(u => u.ReturningRequestRepository.GetRequestByIdAsync(It.IsAny<Guid>()))
							 .ReturnsAsync(request);

			// Act & Assert
			await Assert.ThrowsAsync<BadRequestException>(() => _returningRequestService.CompleteReturnRequestByIdAsync(request.Id));
		}
		[Fact]
		public async Task CompleteReturnRequestByIdAsync_Success()
		{
			// Arrange
			var userId = _users[0].Id;
			_currentUserMock.Setup(c => c.UserId).Returns(userId);

			_userManagerMock.Setup(x => x.Users).Returns(_users.AsQueryable().BuildMockDbSet().Object);

			var returningRequests = _returningRequests.ToList();

			var request = returningRequests.First(r => r.State == ReturningRequestState.WaitingForReturning);

			_unitOfWorkMock.Setup(u => u.ReturningRequestRepository.GetRequestByIdAsync(It.IsAny<Guid>()))
							 .ReturnsAsync(request);

			// Act
			await _returningRequestService.CompleteReturnRequestByIdAsync(request.Id);

			// Assert
			Assert.Equal(ReturningRequestState.Completed, returningRequests.First(r => r.Id == request.Id).State);
			Assert.Equal(AssignmentState.Returned, returningRequests.First(r => r.Id == request.Id).Assignment.State);
			Assert.Equal(AssetState.Available, returningRequests.First(r => r.Id == request.Id).Assignment.Asset!.State);
			Assert.Equal(userId, returningRequests.First(r => r.Id == request.Id).AcceptedByUserId);
			_unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
		}
	}
}
