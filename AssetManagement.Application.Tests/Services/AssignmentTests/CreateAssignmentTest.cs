using AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Moq;
using System.Linq.Expressions;

namespace AssetManagement.Application.Tests.Services.AssignmentTests;
public class CreateAssignmentTest : SetupAssignmentServiceTest
{
    [Fact]
    public async Task CreateAssignmentAsync_ShouldCreateAssignment_WhenRequestIsValid()
    {
        // Arrange
        var request = _fixture.Create<AssignmentCreationRequest>();
        var currentUser = _fixture
            .Build<AppUser>()
            .With(u => u.IsDisabled, false)
            .Create();
        var userAssignedTo = _fixture.Create<AppUser>();
        var asset = _fixture
            .Build<Asset>()
            .With(a => a.Id, request.AssetId)
            .With(a => a.State, AssetState.Available)
            .Create();

        _currentUserMock.Setup(c => c.UserId).Returns(currentUser.Id);
        _userManagerMock.Setup(u => u.FindByIdAsync(currentUser.Id.ToString())).ReturnsAsync(currentUser);
        _userManagerMock.Setup(u => u.FindByIdAsync(request.UserId.ToString())).ReturnsAsync(userAssignedTo);

        _unitOfWorkMock.Setup(u => u.AssignmentRepository).Returns(_assignmentRepositoryMock.Object);
        _unitOfWorkMock.Setup(u => u.AssetRepository).Returns(_assetRepositoryMock.Object);
        _assetRepositoryMock.Setup(a => a.FindOne(It.Is<Expression<Func<Asset, bool>>>(expr => expr.Compile()(asset))))
                          .ReturnsAsync(asset);
        // Act
        var result = await _assignmentService.CreateAssignmentAsync(request);

        // Assert
        _unitOfWorkMock.Verify(u => u.AssignmentRepository.Add(It.IsAny<Assignment>()), Times.Once);
        _unitOfWorkMock.Verify(u => u.AssetRepository.Update(It.Is<Asset>(a => a.State == AssetState.NotAvailable)), Times.Once);
        _unitOfWorkMock.Verify(u => u.SaveChangesAsync(), Times.Once);
        Assert.NotEqual(Guid.Empty, result);
    }

    [Fact]
    public async Task CreateAssignmentAsync_ShouldThrowNotFoundException_WhenUserToBeAssignedNotFound()
    {
        // Arrange
        var request = _fixture.Create<AssignmentCreationRequest>();

        _userManagerMock.Setup(u => u.FindByIdAsync(request.UserId.ToString())).ReturnsAsync((AppUser)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() => _assignmentService.CreateAssignmentAsync(request));
        Assert.Equal("User to assigned is not found!", exception.Message);
    }

    [Fact]
    public async Task CreateAssignmentAsync_ShouldThrowNotFoundException_WhenUserToBeAssignedIsDisabled()
    {
        // Arrange
        var request = _fixture.Create<AssignmentCreationRequest>();
        var userAssignedTo = _fixture
            .Build<AppUser>()
            .With(u => u.IsDisabled, true)
            .Create();
        _userManagerMock.Setup(u => u.FindByIdAsync(request.UserId.ToString())).ReturnsAsync(userAssignedTo);
        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _assignmentService.CreateAssignmentAsync(request));
        Assert.Equal("User to assigned is disabled!", exception.Message);
    }


    [Fact]
    public async Task CreateAssignmentAsync_ShouldThrowNotFoundException_WhenAssetNotFound()
    {
        // Arrange
        var request = _fixture.Create<AssignmentCreationRequest>();
        var userAssignedTo = _fixture
            .Build<AppUser>()
            .With(u => u.IsDisabled, false)
            .Create();

        _userManagerMock.Setup(u => u.FindByIdAsync(request.UserId.ToString())).ReturnsAsync(userAssignedTo);
        _unitOfWorkMock.Setup(u => u.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync((Asset)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() => _assignmentService.CreateAssignmentAsync(request));
        Assert.Equal("Asset to assigned is not found!", exception.Message);
    }

    [Fact]
    public async Task CreateAssignmentAsync_ShouldThrowBadRequestException_WhenAssetNotAvailable()
    {
        // Arrange
        var request = _fixture.Create<AssignmentCreationRequest>();
        var userAssignedTo = _fixture
            .Build<AppUser>()
            .With(u => u.IsDisabled, false)
            .Create(); ;
        var asset = _fixture.Build<Asset>().With(a => a.State, AssetState.NotAvailable).Create();

        _userManagerMock.Setup(u => u.FindByIdAsync(request.UserId.ToString())).ReturnsAsync(userAssignedTo);
        _unitOfWorkMock.Setup(u => u.AssetRepository.FindOne(It.IsAny<Expression<Func<Asset, bool>>>())).ReturnsAsync(asset);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _assignmentService.CreateAssignmentAsync(request));
        Assert.Equal("Asset is not available to assigned!", exception.Message);
    }
}
