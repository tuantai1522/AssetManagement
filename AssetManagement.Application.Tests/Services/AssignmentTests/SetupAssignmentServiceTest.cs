using AssetManagement.Application.Services.Implementations;
using AssetManagement.Data.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace AssetManagement.Application.Tests.Services.AssignmentTests;
public class SetupAssignmentServiceTest : SetupTest
{
    protected readonly Mock<ILogger<AssignmentService>> _mockLogger;
    protected readonly Mock<IAssignmentRepository> _assignmentRepositoryMock;
    protected readonly AssignmentService _assignmentService;
	protected readonly Mock<IAssetRepository> _assetRepositoryMock;
	public SetupAssignmentServiceTest() : base()
    {
		_assignmentRepositoryMock = new Mock<IAssignmentRepository>();
		_assetRepositoryMock = new Mock<IAssetRepository>();
		_mockLogger = new Mock<ILogger<AssignmentService>>();
        
		_assignmentService = new AssignmentService(_mockLogger.Object, _unitOfWorkMock.Object, _currentUserMock.Object, _mapperConfig, _userManagerMock.Object);
    }
}
