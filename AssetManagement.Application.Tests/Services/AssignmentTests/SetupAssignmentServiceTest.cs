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

namespace AssetManagement.Application.Tests.Services.AssignmentTests;
public class SetupAssignmentServiceTest
{
    protected readonly IFixture _fixture;
    protected IAssignmentService _assignmentService;
    protected readonly Mock<UserManager<AppUser>> _userManagerMock;
    protected readonly Mock<IAssignmentRepository> _assignmentRepositoryMock;
    protected readonly Mock<IAssetRepository> _assetRepositoryMock;
    protected readonly IMapper _mapperConfig;
    protected readonly Mock<ICurrentUser> _currentUserMock;
    protected readonly Mock<IUnitOfWork> _unitOfWorkMock;
    public SetupAssignmentServiceTest()
    {
        _fixture = new Fixture().Customize(new AutoMoqCustomization());
        _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        _userManagerMock = _fixture.Freeze<Mock<UserManager<AppUser>>>();
        _currentUserMock = new Mock<ICurrentUser>();
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });
        _mapperConfig = mappingConfig.CreateMapper();
        _assignmentRepositoryMock = new Mock<IAssignmentRepository>();
        _assetRepositoryMock = new Mock<IAssetRepository>();
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _assignmentService = new AssignmentService(_currentUserMock.Object, _unitOfWorkMock.Object, _userManagerMock.Object);
    }
}
