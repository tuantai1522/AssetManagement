using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Implementations;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace AssetManagement.Application.Tests.Services.AssetTests;
public class SetupAssetServiceTest
{
    protected readonly IFixture _fixture;

    protected readonly Mock<ICurrentUser> _currentUserMock;
    protected readonly Mock<UserManager<AppUser>> _userManagerMock;
    protected readonly IMapper _mapperConfig;
    protected readonly Mock<IUnitOfWork> _mockUnitOfWork;
    protected readonly Mock<IAssetRepository> _mockAssetRepository;

    protected IAssetService _assetService;

    public SetupAssetServiceTest()
    {
        _fixture = new Fixture().Customize(new AutoMoqCustomization());
        _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        _currentUserMock = new Mock<ICurrentUser>();
        _userManagerMock = _fixture.Freeze<Mock<UserManager<AppUser>>>();
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });
        _mapperConfig = mappingConfig.CreateMapper();
        _mockUnitOfWork = new Mock<IUnitOfWork>();
        _mockAssetRepository = new Mock<IAssetRepository>();

        _assetService = new AssetService(_currentUserMock.Object, _mapperConfig, _mockUnitOfWork.Object, _userManagerMock.Object);

    }
}
