using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using MockQueryable.Moq;
using Moq;

namespace AssetManagement.Application.Tests.Services.ReturningRequestTests
{
    public class CreateRequestByUserTest : ReturningRequestServiceTestSetup
    {
        [Fact]
        public async Task Create_Request_With_Assignment_Which_Can_Not_Found()
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
            var ex = await Assert.ThrowsAsync<NotFoundException>(() => _service
                                                    .CreateRequestByUserAsync(request));

            //Assert
            Assert.Equal("Can't find assignment", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Create_Request_With_User_Which_Can_Not_Found()
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
            var ex = await Assert.ThrowsAsync<NotFoundException>(() => _service.
                                                    CreateRequestByUserAsync(request));

            Assert.Equal("User is not found!", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task User_Disabled_Can_Not_Create_Request()
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
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _service.CreateRequestByUserAsync(request));
            Assert.Equal("Your account is disabled!", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Create_Request_With_Assignment_Which_Does_Not_Beblong_To_This_User()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var user = _fixture.Build<AppUser>()
                   .With(x => x.IsDisabled, false)
                   .Create();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .With(x => x.AssignedToId, Guid.NewGuid())
                        .Create(),
            };


            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<NotFoundException>(() => _service.CreateRequestByUserAsync(request));
            Assert.Equal("This assignment doesn't belong to this user", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Create_Request_With_State_Is_Not_Accepted()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var user = _fixture.Build<AppUser>()
                   .With(x => x.IsDisabled, false)
                   .Create();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .With(x => x.AssignedToId, user.Id)
                        .With(x => x.State, AssignmentState.Returned)
                        .Create(),
            };


            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _service.CreateRequestByUserAsync(request));
            Assert.Equal("Can't create request with assignment's state is not Accepted", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Admin_Can_Create_Request()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var role = new Role { Name = "Admin" };
            var user = _fixture.Build<AppUser>()
                        .With(x => x.IsDisabled, false)
                        .With(x => x.UserRoles, new List<UserRole> { new UserRole { RoleId = role.Id } })
                        .Create();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .With(x => x.AssignedToId, user.Id)
                        .With(x => x.State, AssignmentState.Accepted)
                        .Create(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            _unitOfWorkMock.Setup(u => u.ReturningRequestRepository).Returns(_returningRequestRepositoryMock.Object);

            // Act
            await _service.CreateRequestByUserAsync(request);

            // Assert
            _unitOfWorkMock.Verify(repo => repo.ReturningRequestRepository.Add(It.IsAny<ReturningRequest>()), Times.Once);
            _unitOfWorkMock.Verify(repo => repo.SaveChangesAsync(), Times.Once);

            Assert.Equal(assignments[0].State, AssignmentState.WaitingForReturning);

        }

        [Fact]
        public async Task Staff_Can_Create_Request()
        {
            // Arrange
            var request = _fixture.Create<Guid>();

            var role = new Role { Name = "Staff" };
            var user = _fixture.Build<AppUser>()
                        .With(x => x.IsDisabled, false)
                        .With(x => x.UserRoles, new List<UserRole> { new UserRole { RoleId = role.Id } })
                        .Create();

            var assignments = new[]
            {
                _fixture.Build<Assignment>()
                        .With(x => x.Id, request)
                        .With(x => x.AssignedToId, user.Id)
                        .With(x => x.State, AssignmentState.Accepted)
                        .Create(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssignmentRepository.GetQueryableSet()).Returns(assignments.AsQueryable().BuildMock());

            _unitOfWorkMock.Setup(u => u.ReturningRequestRepository).Returns(_returningRequestRepositoryMock.Object);

            // Act
            await _service.CreateRequestByUserAsync(request);

            // Assert
            _unitOfWorkMock.Verify(repo => repo.ReturningRequestRepository.Add(It.IsAny<ReturningRequest>()), Times.Once);
            _unitOfWorkMock.Verify(repo => repo.SaveChangesAsync(), Times.Once);

            Assert.Equal(assignments[0].State, AssignmentState.WaitingForReturning);

        }
    }
}
