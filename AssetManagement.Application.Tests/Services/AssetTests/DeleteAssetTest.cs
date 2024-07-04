using AssetManagement.Application.Services.Implementations;
using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;
using System.Linq.Expressions;

namespace AssetManagement.Application.Tests.Services.AssetTests
{
    public class DeleteAssetTest : SetupAssetServiceTest
    {
        public DeleteAssetTest()
        {

        }
        [Fact]
        public async Task Delete_Asset_Which_Can_Not_Found()
        {
            // Arrange
            var request = _fixture.Create<AssetDeleteRequest>();

            var assets = new[]
            {
                _fixture.Create<Asset>(),
                _fixture.Create<Asset>(),
            };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<NotFoundException>(() => _assetService.DeleteAssetAsync(request));

            // Assert
            Assert.Equal("Can't find asset", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Delete(It.IsAny<Guid>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Delete_Asset_Which_Is_Being_Assigned()
        {
            // Arrange
            var request = _fixture.Create<AssetDeleteRequest>();

            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.Id)
                        .With(x => x.State, AssetState.Assigned)
                        .Create(),
                _fixture.Create<Asset>(),
            };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _assetService.DeleteAssetAsync(request));

            // Assert
            Assert.Equal("Can't delete asset which have state is assigned", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Delete(It.IsAny<Guid>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Delete_Asset_Which_Has_Historical_Assignment()
        {
            // Arrange
            var request = _fixture.Create<AssetDeleteRequest>();

            var assignments = new[]
            {
                _fixture.Create<Assignment>(),
            };
            
            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.Id)
                        .With(x => x.Assignments, assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _assetService.DeleteAssetAsync(request));

            // Assert
            Assert.Equal("Can't delete asset which belongs to one or more historical assignments", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Delete(It.IsAny<Guid>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Can_Not_Find_User_To_Delete_Asset()
        {
            // Arrange
            var request = _fixture.Create<AssetDeleteRequest>();

            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.Id)
                        .Without(x => x.Assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());
            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(null as AppUser);

            // Act
            var ex = await Assert.ThrowsAsync<NotFoundException>(() => _assetService.DeleteAssetAsync(request));

            // Assert
            Assert.Equal("User is not found!", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Delete(It.IsAny<Guid>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task User_Disabled_Can_Not_Delete_Asset()
        {
            // Arrange
            var request = _fixture.Create<AssetDeleteRequest>();

            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.Id)
                        .Without(x => x.Assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };

            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, true)
                               .Create();

            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());
            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _assetService.DeleteAssetAsync(request));

            // Assert
            Assert.Equal("Your account is disabled!", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Delete(It.IsAny<Guid>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task User_And_Asset_Are_Different_Location()
        {
            // Arrange
            var request = _fixture.Create<AssetDeleteRequest>();

            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.Id)
                        .Without(x => x.Assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };

            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, false)
                               .Create();

            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());
            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _assetService.DeleteAssetAsync(request));

            // Assert
            Assert.Equal("This asset doesn't belong to this user", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Delete(It.IsAny<Guid>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task User_Can_Delete_Asset()
        {
            // Arrange
            var request = _fixture.Create<AssetDeleteRequest>();

            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.Id)
                        .With(x => x.Location, "SameLocation")
                        .Without(x => x.Assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };

            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, false)
                               .With(x => x.Location, "SameLocation")
                               .Create();

            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());
            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            // Act
            await _assetService.DeleteAssetAsync(request);

            // Assert
            _unitOfWorkMock.Verify(repo => repo.AssetRepository.Delete(It.IsAny<Guid>()), Times.Once);
            _unitOfWorkMock.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }


    }
}
