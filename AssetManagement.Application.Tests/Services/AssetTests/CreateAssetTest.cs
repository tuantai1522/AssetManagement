using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using MockQueryable.Moq;
using Moq;
using System.Linq.Expressions;

namespace AssetManagement.Application.Tests.Services.AssetTests;
public class CreateAssetTest : SetupAssetServiceTest
{
    public CreateAssetTest()
    {

    }

    [Fact]
    public async Task CreateAssetAsync_Should_CreateAsset_When_RequestIsValid()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var categoryId = Guid.NewGuid();
        var request = _fixture.Create<AssetCreationRequest>();
        request.CategoryId = categoryId;

        var user = new AppUser
        {
            Id = userId,
            Location = "Location1",
            IsDisabled = false
        };

        var category = new Category
        {
            Id = categoryId,
            Prefix = "CAT"
        };

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _mockUnitOfWork.Setup(x => x.CategoryRepo.FindOne(It.IsAny<Expression<Func<Category, bool>>>())).ReturnsAsync(category);

        var assets = new List<Asset>().AsQueryable().BuildMock(); // Use Moq.AutoMock to create IQueryable mock
        _mockAssetRepo.Setup(m => m.GetQueryableSet()).Returns(assets);
        _mockUnitOfWork.Setup(u => u.AssetRepo).Returns(_mockAssetRepo.Object);

        // Act
        var result = await _assetService.CreateAssetAsync(request);

        // Assert
        _mockUnitOfWork.Verify(x => x.AssetRepo.Add(It.IsAny<Asset>()), Times.Once);
        _mockUnitOfWork.Verify(x => x.SaveChangesAsync(), Times.Once);
        Assert.NotNull(result);
        Assert.Equal(user.Location, result.Location);
        Assert.StartsWith(category.Prefix, result.AssetCode);
    }

    [Fact]
    public async Task CreateAssetAsync_Should_ThrowNotFoundException_When_UserNotFound()
    {
        // Arrange
        _currentUserMock.Setup(x => x.UserId).Returns(Guid.NewGuid());
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((AppUser)null);

        var request = _fixture.Create<AssetCreationRequest>();

        // Act & Assert
        await Assert.ThrowsAsync<NotFoundException>(() => _assetService.CreateAssetAsync(request));
    }

    [Fact]
    public async Task CreateAssetAsync_Should_ThrowBadRequestException_When_UserIsDisabled()
    {
        // Arrange
        var user = new AppUser { IsDisabled = true };
        _currentUserMock.Setup(x => x.UserId).Returns(Guid.NewGuid());
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

        var request = _fixture.Create<AssetCreationRequest>();

        // Act & Assert
        await Assert.ThrowsAsync<BadRequestException>(() => _assetService.CreateAssetAsync(request));
    }

    [Fact]
    public async Task CreateAssetAsync_Should_ThrowNotFoundException_When_CategoryNotFound()
    {
        // Arrange
        var user = new AppUser { IsDisabled = false };
        _currentUserMock.Setup(x => x.UserId).Returns(Guid.NewGuid());
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _mockUnitOfWork.Setup(x => x.CategoryRepo.FindOne(It.IsAny<Expression<Func<Category, bool>>>())).ReturnsAsync((Category)null);

        var request = _fixture.Create<AssetCreationRequest>();

        // Act & Assert
        await Assert.ThrowsAsync<NotFoundException>(() => _assetService.CreateAssetAsync(request));
    }

    [Fact]
    public async Task CreateAssetAsync_Should_GenerateCorrectAssetCode_When_NoExistingAssets()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var categoryId = Guid.NewGuid();
        var request = _fixture.Create<AssetCreationRequest>();
        request.CategoryId = categoryId;

        var user = new AppUser
        {
            Id = userId,
            Location = "Location1",
            IsDisabled = false
        };

        var category = new Category
        {
            Id = categoryId,
            Prefix = "CAT"
        };

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _mockUnitOfWork.Setup(x => x.CategoryRepo.FindOne(It.IsAny<Expression<Func<Category, bool>>>())).ReturnsAsync(category);

        var assets = new List<Asset>().AsQueryable().BuildMock(); // No existing assets

        _mockAssetRepo.Setup(m => m.GetQueryableSet()).Returns(assets);
        _mockUnitOfWork.Setup(u => u.AssetRepo).Returns(_mockAssetRepo.Object);

        // Act
        var result = await _assetService.CreateAssetAsync(request);

        // Assert
        _mockUnitOfWork.Verify(x => x.AssetRepo.Add(It.Is<Asset>(a => a.AssetCode == "CAT000001")), Times.Once);
        _mockUnitOfWork.Verify(x => x.SaveChangesAsync(), Times.Once);
        Assert.NotNull(result);
        Assert.Equal("CAT000001", result.AssetCode);
    }

    [Fact]
    public async Task CreateAssetAsync_Should_GenerateCorrectAssetCode_When_ThereAreExistingAssets()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var categoryId = Guid.NewGuid();
        var request = _fixture.Build<AssetCreationRequest>()
                            .With(b => b.CategoryId, categoryId)
                            .Create();

        var user = new AppUser
        {
            Id = userId,
            Location = "Location1",
            IsDisabled = false
        };

        var category = new Category
        {
            Id = categoryId,
            Prefix = "CAT"
        };

        var existingAsset = new Asset
        {
            CategoryId = categoryId,
            AssetCode = "CAT000001"
        };

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _mockUnitOfWork.Setup(x => x.CategoryRepo.FindOne(It.IsAny<Expression<Func<Category, bool>>>())).ReturnsAsync(category);

        var assets = new List<Asset> { existingAsset }.AsQueryable().BuildMock();

        _mockAssetRepo.Setup(m => m.GetQueryableSet()).Returns(assets);
        _mockUnitOfWork.Setup(u => u.AssetRepo).Returns(_mockAssetRepo.Object);

        // Act
        var result = await _assetService.CreateAssetAsync(request);

        // Assert
        _mockUnitOfWork.Verify(x => x.AssetRepo.Add(It.Is<Asset>(a => a.AssetCode == "CAT000002")), Times.Once);
        _mockUnitOfWork.Verify(x => x.SaveChangesAsync(), Times.Once);
        Assert.NotNull(result);
        Assert.Equal("CAT000002", result.AssetCode);
    }

    [Fact]
    public async Task CreateAssetAsync_Should_SetCorrectLocation_When_UserIsFound()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var categoryId = Guid.NewGuid();
        var request = _fixture.Create<AssetCreationRequest>();
        request.CategoryId = categoryId;

        var user = new AppUser
        {
            Id = userId,
            Location = "Location1",
            IsDisabled = false
        };

        var category = new Category
        {
            Id = categoryId,
            Prefix = "CAT"
        };

        _currentUserMock.Setup(x => x.UserId).Returns(userId);
        _userManagerMock.Setup(x => x.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _mockUnitOfWork.Setup(x => x.CategoryRepo.FindOne(It.IsAny<Expression<Func<Category, bool>>>())).ReturnsAsync(category);

        var assets = new List<Asset>().AsQueryable().BuildMock();

        _mockAssetRepo.Setup(m => m.GetQueryableSet()).Returns(assets);
        _mockUnitOfWork.Setup(u => u.AssetRepo).Returns(_mockAssetRepo.Object);

        // Act
        var result = await _assetService.CreateAssetAsync(request);

        // Assert
        _mockUnitOfWork.Verify(x => x.AssetRepo.Add(It.Is<Asset>(a => a.Location == user.Location)), Times.Once);
        _mockUnitOfWork.Verify(x => x.SaveChangesAsync(), Times.Once);
        Assert.NotNull(result);
        Assert.Equal(user.Location, result.Location);
    }
}
