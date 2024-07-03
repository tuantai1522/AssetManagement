using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
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
        public async Task UpdateAssetById_IdIsEmpty_ThrowsBadRequestException()
        {
            // Arrange
            var request = new AssetUpdateRequest
            {
                AssetId = Guid.Empty
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<BadRequestException>
                (() => _assetService.UpdateAssetAsync(request));

            Assert.Equal("Please provide id to update asset", exception.Message);
        }

        [Fact]
        public async Task UpdateAssetById_AnyFieldIsEmpty_ThrowsBadRequestException()
        {
            // Arrange
            var request = new AssetUpdateRequest
            {
                AssetId = Guid.NewGuid(),
                AssetName = "",
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<BadRequestException>
                (() => _assetService.UpdateAssetAsync(request));

            Assert.Equal("Please provide full info to update asset", exception.Message);
        }

        [Fact]
        public async Task UpdateAssetById_CanNotFindAsset_ThrowsNotFoundException()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();

            _unitOfWorkMock.Setup(x => x.AssetRepository.Get(
                                    It.IsAny<Expression<Func<Asset, bool>>>(),
                                    It.IsAny<Func<IQueryable<Asset>, IOrderedQueryable<Asset>>>(),
                                    It.IsAny<string>() // includeProperties: "Category"
                                ))
                           .Returns((Expression<Func<Asset, bool>> filter,
                                     Func<IQueryable<Asset>,
                                     IOrderedQueryable<Asset>> orderBy, string includeProperties) =>
                           {
                               return Enumerable.Empty<Asset>();
                           });


            // Act & Assert
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _assetService.UpdateAssetAsync(request));
            Assert.Equal("Can't find asset", exception.Message);
        }

        [Fact]
        public async Task UpdateAssetById_CanNotFindUser_ThrowsNotFoundException()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();

            // Mock AssetRepo to return null for any FindByIdAsync call
            List<Asset> Assets = new List<Asset>
                {
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                };

            _unitOfWorkMock.Setup(x => x.AssetRepository.Get(
                        It.IsAny<Expression<Func<Asset, bool>>>(),
                        It.IsAny<Func<IQueryable<Asset>, IOrderedQueryable<Asset>>>(),
                        It.IsAny<string>() // includeProperties: "Category"
                    ))
               .Returns((Expression<Func<Asset, bool>> filter,
                         Func<IQueryable<Asset>,
                         IOrderedQueryable<Asset>> orderBy, string includeProperties) =>
               {
                   return Assets;
               });

            // Mock UserManager to return null for any FindByIdAsync call
            _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>()))
                            .ReturnsAsync(null as AppUser);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _assetService.UpdateAssetAsync(request));
            Assert.Equal("Can't find user to update", exception.Message);
        }

        [Fact]
        public async Task UpdateAssetById_UserIsDisabledCanNotUpdate_ThrowsUnauthorizedException()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();

            // Mock AssetRepo to return null for any FindByIdAsync call

            List<Asset> Assets = new List<Asset>
                {
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                };

            _unitOfWorkMock.Setup(x => x.AssetRepository.Get(
                        It.IsAny<Expression<Func<Asset, bool>>>(),
                        It.IsAny<Func<IQueryable<Asset>, IOrderedQueryable<Asset>>>(),
                        It.IsAny<string>() // includeProperties: "Category"
                    ))
               .Returns((Expression<Func<Asset, bool>> filter,
                         Func<IQueryable<Asset>,
                         IOrderedQueryable<Asset>> orderBy, string includeProperties) =>
               {
                   return Assets;
               });

            var user = _fixture.Build<AppUser>()
                               .With(r => r.IsDisabled, true)
                               .Create();

            // Mock UserManager to return null for any FindByIdAsync call
            _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>()))
                            .ReturnsAsync(user);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<UnauthorizedException>(() => _assetService.UpdateAssetAsync(request));
            Assert.Equal("This user can't update this asset", exception.Message);
        }

        [Fact]
        public async Task UpdateAssetById_UserCanUpdateAsset_ShouldReturnNull()
        {
            // Arrange
            var request = _fixture.Create<AssetUpdateRequest>();

            // Mock AssetRepo to return null for any FindByIdAsync call
            List<Asset> Assets = new List<Asset>
                {
                    _fixture.Build<Asset>()
                            .With(x => x.Location, "HCM")
                            .Create(),
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                };

            _unitOfWorkMock.Setup(x => x.AssetRepository.Get(
                        It.IsAny<Expression<Func<Asset, bool>>>(),
                        It.IsAny<Func<IQueryable<Asset>, IOrderedQueryable<Asset>>>(),
                        It.IsAny<string>() // includeProperties: "Category"
                    ))
               .Returns((Expression<Func<Asset, bool>> filter,
                         Func<IQueryable<Asset>,
                         IOrderedQueryable<Asset>> orderBy, string includeProperties) =>
               {
                   return Assets;
               });

            var user = _fixture.Build<AppUser>()
                               .With(r => r.IsDisabled, false)
                               .With(x => x.Location, "HCM")
                               .Create();

            // Mock UserManager to return null for any FindByIdAsync call
            _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>()))
                            .ReturnsAsync(user);
            
            // Act & Assert
            await _assetService.UpdateAssetAsync(request);

            _unitOfWorkMock.Verify(repo => repo.AssetRepository.Update(Assets[0]), Times.Once);
            _unitOfWorkMock.Verify(repo => repo.SaveChangesAsync(), Times.Once);
        }

    }
}
