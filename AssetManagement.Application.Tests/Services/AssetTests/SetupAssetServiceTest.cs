using AssetManagement.Application.Services.Implementations;
using AssetManagement.Data.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace AssetManagement.Application.Tests.Services.AssetTests;
public class SetupAssetServiceTest : SetupTest
{
    protected readonly Mock<ILogger<AssetService>> _mockLogger;
    protected readonly Mock<IAssetRepository> _assetRepositoryMock;
    protected readonly AssetService _assetService;
    public SetupAssetServiceTest() : base()
    {
        _assetRepositoryMock = new Mock<IAssetRepository>();
        _mockLogger = new Mock<ILogger<AssetService>>();

        _assetService = new AssetService(_mockLogger.Object, _unitOfWorkMock.Object, _currentUserMock.Object, _mapperConfig, _userManagerMock.Object);
    }
}
