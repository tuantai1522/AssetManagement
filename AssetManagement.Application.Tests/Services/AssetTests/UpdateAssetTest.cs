using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Microsoft.AspNetCore.Routing;
using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests.Services.AssetTests
{
    public class UpdateAssetTest : SetupAssetServiceTest
    {
        public UpdateAssetTest()
        {

        }

        [Fact]
        public async Task Update_Asset_Which_Can_Not_Found()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();
            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, false)
                               .Create();
            var assets = new[]
{
                _fixture.Create<Asset>(),
                _fixture.Create<Asset>(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<NotFoundException>(() => _assetService.UpdateAssetAsync(request));

            //Assert
            Assert.Equal("Can't find asset", ex.Message);
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Update_Asset_Which_Is_Not_Available()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();
            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, false)
                               .Create();

            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.AssetId)
                        .With(x => x.State, AssetState.NotAvailable)
                        .Create(),
                _fixture.Create<Asset>(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _assetService.UpdateAssetAsync(request));
            Assert.Equal("Can't edit asset whose state is not Available", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task Can_Not_Find_User_To_Update_Asset()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();

            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.AssetId)
                        .With(x => x.State, AssetState.NotAvailable)
                        .Without(x => x.Assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(null as AppUser);
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _assetService.UpdateAssetAsync(request));
            Assert.Equal("Can't edit asset whose state is not Available", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task User_Disabled_Can_Not_Update_Asset()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();
            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, true)
                               .Create();

            var assets = new[]
            {
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.AssetId)
                        .With(x => x.State, AssetState.Available)
                        .Without(x => x.Assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());


            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _assetService.UpdateAssetAsync(request));
            Assert.Equal("Your account is disabled!", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task User_And_Asset_Are_Different_Location()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();
            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, false)
                               .With(x => x.Location, "DifferentLocation")
                               .Create();

            var assets = new[]
{
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.AssetId)
                        .With(x => x.Location, "OtherLocations")
                        .With(x => x.State, AssetState.Available)
                        .Without(x => x.Assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            // Act
            var ex = await Assert.ThrowsAsync<BadRequestException>(() => _assetService.UpdateAssetAsync(request));
            Assert.Equal("This asset doesn't belong to this user", ex.Message);

            //Assert
            _unitOfWorkMock.Verify(m => m.AssetRepository.Update(It.IsAny<Asset>()), Times.Never);
            _unitOfWorkMock.Verify(m => m.SaveChangesAsync(), Times.Never);
        }

        [Fact]
        public async Task User_Can_Update_Asset()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();
            var user = _fixture.Build<AppUser>()
                               .With(x => x.IsDisabled, false)
                               .With(x => x.Location, "SameLocation")
                               .Create();

            var assets = new[]
{
                _fixture.Build<Asset>()
                        .With(x => x.Id, request.AssetId)
                        .With(x => x.Location, "SameLocation")
                        .With(x => x.State, AssetState.Available)
                        .Without(x => x.Assignments)
                        .Create(),
                _fixture.Create<Asset>(),
            };

            _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);

            _unitOfWorkMock.Setup(u => u.AssetRepository.GetQueryableSet()).Returns(assets.AsQueryable().BuildMock());

            // Act
            await _assetService.UpdateAssetAsync(request);

            // Assert
            _unitOfWorkMock.Verify(repo => repo.AssetRepository.Update(It.IsAny<Asset>()), Times.Once);
            _unitOfWorkMock.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

    }
}
