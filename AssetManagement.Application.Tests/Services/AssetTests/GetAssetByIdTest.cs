using AssetManagement.Contracts.Dtos.AssetDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Moq;
using System.Linq.Expressions;

namespace AssetManagement.Application.Tests.Services.AssetTests
{
    public class GetAssetByIdTest : SetupAssetServiceTest
    {
        public GetAssetByIdTest()
        {

        }

        [Fact]
        public async Task GetAssetById_IdIsEmpty_ThrowsBadRequestException()
        {
            // Arrange
            var request = new AssetDetailsRequest
            {
                Id = Guid.Empty
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<BadRequestException>
                (() => _assetService.GetAssetByIdAsync(request));

            Assert.Equal("Please provide id to get asset", exception.Message);
        }

        [Fact]
        public async Task GetAssetById_CanNotFindAsset_ThrowsNotFoundException()
        {
            // Arrange
            var request = new AssetDetailsRequest
            {
                Id = Guid.NewGuid()
            };

            _mockUnitOfWork.Setup(x => x.AssetRepo.Get(
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
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _assetService.GetAssetByIdAsync(request));
            Assert.Equal("Can't find asset", exception.Message);
        }

        [Fact]
        public async Task GetAssetById_CanNotFindUser_ThrowsNotFoundException()
        {
            // Arrange
            var request = new AssetDetailsRequest
            {
                Id = Guid.NewGuid()
            };
            // Mock AssetRepo to return null for any FindByIdAsync call
            var asset = _fixture.Create<Asset>();

            List <Asset> Assets = new List<Asset>
                {
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                };

            _mockUnitOfWork.Setup(x => x.AssetRepo.Get(
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
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _assetService.GetAssetByIdAsync(request));
            Assert.Equal("Can't find user", exception.Message);
        }

        [Fact]
        public async Task GetAssetById_UserCanNotViewAsset_ThrowsUnauthorizedException()
        {
            // Arrange
            var request = new AssetDetailsRequest
            {
                Id = Guid.NewGuid()
            };
            // Mock AssetRepo to return null for any FindByIdAsync call
            List<Asset> Assets = new List<Asset>
                {
                    _fixture.Build<Asset>()
                            .With(x => x.Location, "HCM")
                            .With(x => x.Id, request.Id)
                            .Create(),
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                };

            _mockUnitOfWork.Setup(x => x.AssetRepo.Get(
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
                               .With(x => x.Location, "HN")
                               .Create();

            // Mock UserManager to return null for any FindByIdAsync call
            _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>()))
                            .ReturnsAsync(user);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<UnauthorizedException>(() => _assetService.GetAssetByIdAsync(request));
            Assert.Equal("This user can't view this asset", exception.Message);
        }


        [Fact]
        public async Task GetAssetById_UserCanViewAsset_ShouldReturnAssetDetailsResponse()
        {
            // Arrange
            var request = new AssetDetailsRequest
            {
                Id = Guid.NewGuid()
            };
            // Mock AssetRepo to return null for any FindByIdAsync call
            List<Asset> Assets = new List<Asset>
                {
                    _fixture.Build<Asset>()
                            .With(x => x.Location, "HCM")
                            .With(x => x.Id, request.Id)
                            .Create(),
                    _fixture.Create<Asset>(),
                    _fixture.Create<Asset>(),
                };

            _mockUnitOfWork.Setup(x => x.AssetRepo.Get(
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
                               .With(x => x.Location, "HCM")
                               .Create();

            // Mock UserManager to return null for any FindByIdAsync call
            _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>()))
                            .ReturnsAsync(user);

            // Act & Assert
            var response = await _assetService.GetAssetByIdAsync(request);

            Assert.NotNull(response);
        }
    }
}