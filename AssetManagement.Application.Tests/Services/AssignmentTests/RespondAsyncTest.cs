using System.Linq.Expressions;
using AssetManagement.Application.Common.Constants;
using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Moq;

namespace AssetManagement.Application.Tests.Services.AssignmentTests;

public class RespondAsyncTest : SetupAssignmentServiceTest
{
    public RespondAsyncTest() : base() { }

    [Fact]
    public async Task RespondAsync_WhenRespondingUserIsAssignedUser_ShouldReturnTrue()
    {
        // Arrange
        var assignmentId = Guid.NewGuid();
        var assetId = Guid.NewGuid();
        var userId = Guid.NewGuid();
        var request = new RespondAssignmentRequest
        {
            IsAccepted = true,
        };
        var user = new AppUser
        {
            Id = userId
        };
        var asset = _fixture.Build<Asset>()
            .With(r => r.Id, assignmentId)
            .With(r => r.State, AssetState.NotAvailable)
            .Create();
        var assignment = _fixture.Build<Assignment>()
            .With(r => r.Id, assignmentId)
            .With(r => r.AssetId, assetId)
            .With(r => r.AssignedToId, userId)
            .With(r => r.State, AssignmentState.WaitingForAcceptance)
            .Create();

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _unitOfWorkMock.Setup(x => x.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync(asset);
        _unitOfWorkMock.Setup(x => x.AssignmentRepository.FindOne(It.IsAny<Expression<Func<Assignment, bool>>>())).ReturnsAsync(assignment);

        // Act
        var result = await _assignmentService.RespondAsync(assignmentId.ToString(), request);

        // Assert
        _unitOfWorkMock.Verify(x => x.SaveChangesAsync(), Times.Once);
        Assert.True(result);
    }

    [Fact]
    public async Task RespondAsync_WhenRespondingUserIsAdmin_ShouldReturnTrue()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var assignmentId = Guid.NewGuid();
        var assetId = Guid.NewGuid();
        var request = new RespondAssignmentRequest
        {
            IsAccepted = true,
        };
        var user = new AppUser
        {
            Id = Guid.NewGuid(),
            UserRoles =
            [
                new UserRole 
                { 
                    Role = new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    }
                }
            ]
        };
        var asset = _fixture.Build<Asset>()
            .With(r => r.Id, assignmentId)
            .With(r => r.State, AssetState.NotAvailable)
            .Create();
        var assignment = _fixture.Build<Assignment>()
            .With(r => r.Id, assignmentId)
            .With(r => r.AssetId, assetId)
            .With(r => r.AssignedToId, userId)
            .With(r => r.State, AssignmentState.WaitingForAcceptance)
            .Create();

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _unitOfWorkMock.Setup(x => x.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync(asset);
        _unitOfWorkMock.Setup(x => x.AssignmentRepository.FindOne(It.IsAny<Expression<Func<Assignment, bool>>>())).ReturnsAsync(assignment);

        // Act
        var result = await _assignmentService.RespondAsync(assignmentId.ToString(), request);

        // Assert
        _unitOfWorkMock.Verify(x => x.SaveChangesAsync(), Times.Once);
        Assert.True(result);
    }

    [Fact]
    public async Task RespondAsync_WhenUserNotFound_ShouldThrowException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var assignmentId = Guid.NewGuid();
        var assetId = Guid.NewGuid();
        var request = new RespondAssignmentRequest
        {
            IsAccepted = true,
        };
        var user = new AppUser
        {
            Id = Guid.NewGuid(),
            UserRoles =
            [
                new UserRole 
                { 
                    Role = new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    }
                }
            ]
        };
        var asset = _fixture.Build<Asset>()
            .With(r => r.Id, assignmentId)
            .With(r => r.State, AssetState.NotAvailable)
            .Create();
        var assignment = _fixture.Build<Assignment>()
            .With(r => r.Id, assignmentId)
            .With(r => r.AssetId, assetId)
            .With(r => r.AssignedToId, userId)
            .With(r => r.State, AssignmentState.WaitingForAcceptance)
            .Create();

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(default(AppUser));
        _unitOfWorkMock.Setup(x => x.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync(asset);
        _unitOfWorkMock.Setup(x => x.AssignmentRepository.FindOne(It.IsAny<Expression<Func<Assignment, bool>>>())).ReturnsAsync(assignment);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _assignmentService.RespondAsync(assignmentId.ToString(), request));
        Assert.Equal(ErrorStrings.USER_NOT_FOUND, exception.Message);
    }

    [Fact]
    public async Task RespondAsync_WhenAssignmentNotFound_ShouldThrowException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var assignmentId = Guid.NewGuid();
        var assetId = Guid.NewGuid();
        var request = new RespondAssignmentRequest
        {
            IsAccepted = true,
        };
        var user = new AppUser
        {
            Id = Guid.NewGuid(),
            UserRoles =
            [
                new UserRole 
                { 
                    Role = new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    }
                }
            ]
        };
        var asset = _fixture.Build<Asset>()
            .With(r => r.Id, assignmentId)
            .With(r => r.State, AssetState.NotAvailable)
            .Create();
        var assignment = _fixture.Build<Assignment>()
            .With(r => r.Id, assignmentId)
            .With(r => r.AssetId, assetId)
            .With(r => r.AssignedToId, userId)
            .With(r => r.State, AssignmentState.WaitingForAcceptance)
            .Create();

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _unitOfWorkMock.Setup(x => x.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync(asset);
        _unitOfWorkMock.Setup(x => x.AssignmentRepository.FindOne(It.IsAny<Expression<Func<Assignment, bool>>>())).ReturnsAsync(default(Assignment));

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _assignmentService.RespondAsync(assignmentId.ToString(), request));
        Assert.Equal(ErrorStrings.ASSIGNMENT_NOT_FOUND, exception.Message);
    }

    [Fact]
    public async Task RespondAsync_WhenAssetNotFound_ShouldThrowException()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var assignmentId = Guid.NewGuid();
        var assetId = Guid.NewGuid();
        var request = new RespondAssignmentRequest
        {
            IsAccepted = true,
        };
        var user = new AppUser
        {
            Id = Guid.NewGuid(),
            UserRoles =
            [
                new UserRole 
                { 
                    Role = new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    }
                }
            ]
        };
        var asset = _fixture.Build<Asset>()
            .With(r => r.Id, assignmentId)
            .With(r => r.State, AssetState.NotAvailable)
            .Create();
        var assignment = _fixture.Build<Assignment>()
            .With(r => r.Id, assignmentId)
            .With(r => r.AssetId, assetId)
            .With(r => r.AssignedToId, userId)
            .With(r => r.State, AssignmentState.WaitingForAcceptance)
            .Create();

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _unitOfWorkMock.Setup(x => x.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync(default(Asset));
        _unitOfWorkMock.Setup(x => x.AssignmentRepository.FindOne(It.IsAny<Expression<Func<Assignment, bool>>>())).ReturnsAsync(assignment);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _assignmentService.RespondAsync(assignmentId.ToString(), request));
        Assert.Equal(ErrorStrings.ASSET_NOT_FOUND, exception.Message);
    }

    [Theory]
    [InlineData(AssignmentState.Accepted)]
    [InlineData(AssignmentState.Declined)]
    public async Task RespondAsync_WhenAssignmentStateIsNotWaitingForAcceptance_ShouldThrowException(AssignmentState assignmentState)
    {
        // Arrange
        var userId = Guid.NewGuid();
        var assignmentId = Guid.NewGuid();
        var assetId = Guid.NewGuid();
        var request = new RespondAssignmentRequest
        {
            IsAccepted = true,
        };
        var user = new AppUser
        {
            Id = Guid.NewGuid(),
            UserRoles =
            [
                new UserRole 
                { 
                    Role = new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    }
                }
            ]
        };
        var asset = _fixture.Build<Asset>()
            .With(r => r.Id, assignmentId)
            .With(r => r.State, AssetState.NotAvailable)
            .Create();
        var assignment = _fixture.Build<Assignment>()
            .With(r => r.Id, assignmentId)
            .With(r => r.AssetId, assetId)
            .With(r => r.AssignedToId, userId)
            .With(r => r.State, assignmentState)
            .Create();

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _unitOfWorkMock.Setup(x => x.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync(asset);
        _unitOfWorkMock.Setup(x => x.AssignmentRepository.FindOne(It.IsAny<Expression<Func<Assignment, bool>>>())).ReturnsAsync(assignment);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _assignmentService.RespondAsync(assignmentId.ToString(), request));
        Assert.Equal(ErrorStrings.INVALID_ASSIGNMENT_STATE_FOR_RESPONDING, exception.Message);
    }

    [Theory]
    [InlineData(AssetState.Available)]
    [InlineData(AssetState.WaitingForRecycling)]
    [InlineData(AssetState.Recycled)]
    [InlineData(AssetState.Assigned)]
    public async Task RespondAsync_WhenAssetStateIsNotNotAvailable_ShouldThrowException(AssetState assetState)
    {
        // Arrange
        var userId = Guid.NewGuid();
        var assignmentId = Guid.NewGuid();
        var assetId = Guid.NewGuid();
        var request = new RespondAssignmentRequest
        {
            IsAccepted = true,
        };
        var user = new AppUser
        {
            Id = Guid.NewGuid(),
            UserRoles =
            [
                new UserRole 
                { 
                    Role = new Role()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    }
                }
            ]
        };
        var asset = _fixture.Build<Asset>()
            .With(r => r.Id, assignmentId)
            .With(r => r.State, assetState)
            .Create();
        var assignment = _fixture.Build<Assignment>()
            .With(r => r.Id, assignmentId)
            .With(r => r.AssetId, assetId)
            .With(r => r.AssignedToId, userId)
            .With(r => r.State, AssignmentState.WaitingForAcceptance)
            .Create();

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _unitOfWorkMock.Setup(x => x.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync(asset);
        _unitOfWorkMock.Setup(x => x.AssignmentRepository.FindOne(It.IsAny<Expression<Func<Assignment, bool>>>())).ReturnsAsync(assignment);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _assignmentService.RespondAsync(assignmentId.ToString(), request));
        Assert.Equal(ErrorStrings.INVALID_ASSET_STATE_FOR_RESPONDING, exception.Message);
    }
}