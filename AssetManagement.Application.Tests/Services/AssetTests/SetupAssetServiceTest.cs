using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Implementations;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Moq;

namespace AssetManagement.Application.Tests.Services.AssetTests;
public class SetupAssetServiceTest
{
    protected readonly IFixture _fixture;

    protected readonly Mock<ICurrentUser> _currentUserMock;
    protected readonly Mock<UserManager<AppUser>> _userManagerMock;
    protected readonly IMapper _mapperConfig;
    protected readonly Mock<IUnitOfWork> _unitOfWorkMock;
    protected readonly Mock<ILogger<AssetService>> _mockLogger;

    protected readonly Mock<IAssetRepository> _assetRepositoryMock;
    protected readonly AssetService _assetService;

    protected List<Role> Roles;
    protected List<AppUser> Users;

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
        _unitOfWorkMock = new Mock<IUnitOfWork>();
        _assetRepositoryMock = new Mock<IAssetRepository>();
        _mockLogger = new Mock<ILogger<AssetService>>();

        _mockAssetService = new AssetService(_mockLogger.Object, _mockUnitOfWork.Object, _mockCurrentUser.Object, _mapperConfig, _mockUserManager.Object);

        Setup();
    }
    #region setup
    protected void Setup()
    {
        Roles = [
        new Role()
        {
            Id = Guid.NewGuid(),
            Name = "Admin",
            NormalizedName = "ADMIN",
        },
        new Role()
        {
            Id = Guid.NewGuid(),
            Name = "Staff",
            NormalizedName = "STAFF",
        }
        ];

        Users = [
           new AppUser (){
            Id = Guid.NewGuid(),
            FirstName = "Admin",
            LastName = "1",
            StaffCode = "SD0001",
            JoinedDate = DateTime.Now,
            Location = Location.HCM.ToString(),
            IsDisabled = false,
            UserRoles = [
                new UserRole() {
                Role = Roles[0]
                }
            ]
        }
        ];

        for (int i = 2; i <= 9; i++)
        {
            Users.Add(new AppUser
            {
                Id = Guid.NewGuid(),
                FirstName = "Staff",
                LastName = i.ToString(),
                StaffCode = $"SD{i:D4}",
                JoinedDate = DateTime.Now.AddDays(i),
                Location = Location.HCM.ToString(),
                IsDisabled = false,
                UserRoles = [
                new UserRole
                {
                    Role = Roles[1]
                }
                ]
            });
        }

        Users.Add(
            new AppUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "10",
                StaffCode = "SD0010",
                JoinedDate = DateTime.Now.AddHours(2),
                Location = Location.HCM.ToString(),
                IsDisabled = false,
                UserRoles = [
                    new UserRole() {
                        Role = Roles[0]
                    }
                ]
            }
            );

    }
    #endregion
}
