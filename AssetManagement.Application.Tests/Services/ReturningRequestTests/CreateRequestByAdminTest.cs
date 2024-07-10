using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AssetManagement.Application.Tests.Services.ReturningRequestTests
{
    public class CreateRequestByAdminTest : SetupReturningRequestServiceTest
    {
        [Fact]
        public async Task CreateRequestByAdmin_WhenAssignmentIsNotFound_ThrowsNotFoundException()
        {
            // Arrange
            var request = _fixture.Create<Guid>();
            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, false)
                               .Create();
            var assignments = new[]
            {
                _fixture.Create<Assignment>(),
                _fixture.Create<Assignment>(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<NotFoundException>(() => _returningRequestService
                                                    .CreateRequestByAdminAsync(request));

            //Assert
            Assert.Equal("Can't find assignment", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task CreateRequestByAdmin_WhenUserIsNotFound_ThrowsNotFoundException()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .Create(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(null as AppUser);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<NotFoundException>(() => _returningRequestService.
                                                    CreateRequestByAdminAsync(request));

            Assert.Equal("User is not found!", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task CreateRequestByAdmin_WhenAdminIsDisabled_ThrowsBadRequestException()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, true)
                               .Create();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .Create(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());


            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _returningRequestService.CreateRequestByAdminAsync(request));
            Assert.Equal("Your account is disabled!", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task CreateRequestByAdmin_WhenLocationIsInvalid_ThrowsBadRequestException()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var user = _fixture.Build<AppUser>()
                   .With(x => x.IsDisabled, false)
                   .With(x => x.Location, "DifferentLocation")
                   .Create();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .Create(),
            };


            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _returningRequestService.CreateRequestByAdminAsync(request));
            Assert.Equal("Location of this assignment is different from location of current user", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task CreateRequestByAdmin_WhenStateIsInvalid_ThrowsBadRequestException()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var user = _fixture.Build<AppUser>()
                   .With(x => x.IsDisabled, false)
                   .With(x => x.Location, "SameLocation")
                   .Create();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .With(x => x.AssignedByUser, new AppUser { Location = "SameLocation" })
                        .With(x => x.State, AssignmentState.Returned)
                        .Create(),
            };


            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _returningRequestService.CreateRequestByAdminAsync(request));
            Assert.Equal("Can't create request with assignment's state is not Accepted", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task CreateRequestByAdmin_CreateSuccessfully()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var user = _fixture.Build<AppUser>()
                   .With(x => x.IsDisabled, false)
                   .With(x => x.Location, "SameLocation")
                   .Create();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .With(x => x.AssignedByUser, new AppUser { Location = "SameLocation" })
                        .With(x => x.State, AssignmentState.Accepted)
                        .Create(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            _unitOfWorkMock.Setup(u => u.ReturningRequestRepository).Returns(_returningRequestRepositoryMock.Object);

            // Act
            await _returningRequestService.CreateRequestByAdminAsync(request);

            // Assert
            _unitOfWorkMock.Verify(repo => repo.ReturningRequestRepository.Add(It.IsAny<ReturningRequest>()), Times.Once);
            _unitOfWorkMock.Verify(repo => repo.SaveChangesAsync(), Times.Once);

            Assert.Equal(assignments[0].State, AssignmentState.WaitingForReturning);

        }
    }
}
