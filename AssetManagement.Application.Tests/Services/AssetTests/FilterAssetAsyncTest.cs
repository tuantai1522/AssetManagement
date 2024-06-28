﻿using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using MockQueryable.Moq;

namespace AssetManagement.Application.Tests.Services.AssetTests
{
    public class FilterAssetAsyncTest : SetupAssetServiceTest
    {
        public FilterAssetAsyncTest() : base()
        {
        }
        [Fact]
        public async Task FilterAssetAsync_UserNotLoggedIn_ThrowsUnauthorizedAccessException()
        {
            // Arrange
            _userManagerMock.Setup(u => u.Users).Returns(Users.AsQueryable().BuildMock());
            _currentUserMock.Setup(u => u.UserId).Returns(Guid.Empty);

            // Act & Assert
            await Assert.ThrowsAsync<UnauthorizedAccessException>(() =>
                 _assetService.FilterAssetAsync(new FilterAssetRequest()));
        }
        [Fact]
        public async Task FilterAssetAsync_UserIsDisabled_ThrowsUnauthorizedAccessException()
        {
            // Arrange
            var currentUser = new AppUser { Id = Guid.NewGuid(), IsDisabled = true };
            _userManagerMock.Setup(u => u.Users).Returns(new[] { currentUser }.AsQueryable().BuildMock());
            _currentUserMock.Setup(c => c.UserId).Returns(currentUser.Id);

            // Act & Assert
            await Assert.ThrowsAsync<UnauthorizedAccessException>(() =>
                _assetService.FilterAssetAsync(new FilterAssetRequest()));
        }
        [Fact]
        public async Task FilterAssetAsync_DefaultPagination_SetsDefaultValues()
        {
            // Arrange
            var currentUser = new AppUser { Id = Guid.NewGuid(), IsDisabled = false, Location = "HCM" };
            _userManagerMock.Setup(u => u.Users).Returns(new[] { currentUser }.AsQueryable().BuildMock());
            _currentUserMock.Setup(c => c.UserId).Returns(currentUser.Id);

            var assets = new[] { new Asset { Id = Guid.NewGuid(), Location = "HCM" } };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            var filter = new FilterAssetRequest();

            // Act
            var result = await _assetService.FilterAssetAsync(filter);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, filter.PageNumber);
            Assert.Equal(5, filter.PageSize);
        }
        [Fact]
        public async Task FilterAssetAsync_SearchOnName_ReturnsFilteredResults()
        {
            // Arrange
            var currentUser = new AppUser { Id = Guid.NewGuid(), IsDisabled = false, Location = "HCM" };
            _userManagerMock.Setup(u => u.Users).Returns(new[] { currentUser }.AsQueryable().BuildMock());
            _currentUserMock.Setup(c => c.UserId).Returns(currentUser.Id);

            var assets = new[]
            {
                new Asset { Id = Guid.NewGuid(), Name = "Asset1", AssetCode = "A001", Location = "HCM" },
                new Asset { Id = Guid.NewGuid(), Name = "Asset2", AssetCode = "A002", Location = "HCM" }
            };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            var filter = new FilterAssetRequest { Search = "Asset1" };

            // Act
            var result = await _assetService.FilterAssetAsync(filter);

            // Assert
            Assert.Single(result.Data);
            Assert.Equal("Asset1", result.Data[0].Name);
        }
        [Fact]
        public async Task FilterAssetAsync_SearchOnAssetCode_ReturnsFilteredResults()
        {
            // Arrange
            var currentUser = new AppUser { Id = Guid.NewGuid(), IsDisabled = false, Location = "HCM" };
            _userManagerMock.Setup(u => u.Users).Returns(new[] { currentUser }.AsQueryable().BuildMock());
            _currentUserMock.Setup(c => c.UserId).Returns(currentUser.Id);

            var assets = new[]
            {
                new Asset { Id = Guid.NewGuid(), Name = "Asset1", AssetCode = "A001", Location = "HCM" },
                new Asset { Id = Guid.NewGuid(), Name = "Asset2", AssetCode = "A002", Location = "HCM" },
                new Asset { Id = Guid.NewGuid(), Name = "Asset3", AssetCode = "B001", Location = "HCM" },
                new Asset { Id = Guid.NewGuid(), Name = "Asset4", AssetCode = "B002", Location = "HCM" },
            };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            var filter = new FilterAssetRequest { Search = "B0" };

            // Act
            var result = await _assetService.FilterAssetAsync(filter);

            // Assert
            Assert.Equal(2, result.Data.Count);
            Assert.Contains(result.Data, a => a.Name == "Asset3");
            Assert.Contains(result.Data, a => a.Name == "Asset4");
        }
        [Fact]
        public async Task FilterAssetAsync_FilterBySpecifiedCriteria_ReturnsOrderedResults()
        {
            // Arrange
            var currentUser = new AppUser { Id = Guid.NewGuid(), IsDisabled = false, Location = "HCM" };
            _userManagerMock.Setup(u => u.Users).Returns(new[] { currentUser }.AsQueryable().BuildMock());
            _currentUserMock.Setup(c => c.UserId).Returns(currentUser.Id);

            var assets = new[]
            {
                new Asset { Id = Guid.NewGuid(), Name = "AssetA1", AssetCode = "A001", Location = "HCM", State = AssetState.Available,
                    Category = new Category { Id = Guid.NewGuid(), Name = "Laptop" } },
                new Asset { Id = Guid.NewGuid(), Name = "AssetA2", AssetCode = "A002", Location = "HCM", State = AssetState.NotAvailable,
                    Category = new Category { Id = Guid.NewGuid(), Name = "Laptop" } },
                new Asset { Id = Guid.NewGuid(), Name = "AssetB1", AssetCode = "B001", Location = "HCM", State = AssetState.Available,
                    Category = new Category { Id = Guid.NewGuid(), Name = "Monitor" } },
                new Asset { Id = Guid.NewGuid(), Name = "AssetB2", AssetCode = "B002", Location = "HCM", State = AssetState.NotAvailable,
                    Category = new Category { Id = Guid.NewGuid(), Name = "Monitor" } },
        };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            var filter = new FilterAssetRequest { States = new AssetState[] { AssetState.Available }, Categories = new[] { "Laptop", "Monitor" } };

            // Act
            var result = await _assetService.FilterAssetAsync(filter);

            // Assert
            Assert.Equal(2, result.Data.Count);
            Assert.Contains(result.Data, a => a.Name == "AssetA1");
            Assert.Contains(result.Data, a => a.Name == "AssetB1");
        }
        [Fact]
        public async Task FilterAssetAsync_SortBySpecifiedCriteria_ReturnsOrderedResults()
        {
            // Arrange
            var currentUser = new AppUser { Id = Guid.NewGuid(), IsDisabled = false, Location = "HCM" };
            _userManagerMock.Setup(u => u.Users).Returns(new[] { currentUser }.AsQueryable().BuildMock());
            _currentUserMock.Setup(c => c.UserId).Returns(currentUser.Id);

            var assets = new[]
            {
                new Asset { Id = Guid.NewGuid(), Name = "AssetA1", AssetCode = "A001", Location = "HCM", State = AssetState.Available,
                    Category = new Category { Id = Guid.NewGuid(), Name = "Laptop" } },
                new Asset { Id = Guid.NewGuid(), Name = "AssetA2", AssetCode = "A002", Location = "HCM", State = AssetState.NotAvailable,
                    Category = new Category { Id = Guid.NewGuid(), Name = "Laptop" } },
                new Asset { Id = Guid.NewGuid(), Name = "AssetB1", AssetCode = "B001", Location = "HCM", State = AssetState.Available,
                    Category = new Category { Id = Guid.NewGuid(), Name = "Monitor" } },
                new Asset { Id = Guid.NewGuid(), Name = "AssetB2", AssetCode = "B002", Location = "HCM", State = AssetState.NotAvailable,
                    Category = new Category { Id = Guid.NewGuid(), Name = "Monitor" } },
        };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            var filter = new FilterAssetRequest { SortAssetCode = SortOption.Asc };

            // Act
            var result = await _assetService.FilterAssetAsync(filter);

            // Assert
            Assert.Equal(4, result.Data.Count);
            Assert.Equal("A001", result.Data[0].AssetCode);
            Assert.Equal("A002", result.Data[1].AssetCode);
            Assert.Equal("B001", result.Data[2].AssetCode);
            Assert.Equal("B002", result.Data[3].AssetCode);
        }
    }
}
