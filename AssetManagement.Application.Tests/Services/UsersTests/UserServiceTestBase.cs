using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Implementations;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AutoFixture;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Moq;

namespace AssetManagement.Application.Tests.Services.UsersTests;
public class UserServiceTestBase
{

    protected readonly Mock<UserManager<AppUser>> UserManagerMock;
    protected readonly Mock<RoleManager<Role>> RoleManagerMock;
    protected readonly Mock<ICurrentUser> CurrentUserMock;

    protected readonly IUserService UserService;
    protected readonly Mock<ILogger<UserService>> LoggerUserMock;

    protected readonly IAssetService AssetServiceMock;
    protected readonly Mock<ILogger<AssetService>> LoggerAssetMock;

    protected readonly Fixture Fixture;
    protected readonly IMapper _mapperConfig;

    protected readonly Mock<IUnitOfWork> UnitOfWorkMock;
    protected readonly Mock<IAssetRepository> AssetRepositoryMock;


    protected List<Role> Roles;

    protected List<AppUser> Users;

    public UserServiceTestBase()
    {
        UserManagerMock = new Mock<UserManager<AppUser>>(Mock.Of<IUserStore<AppUser>>(), null!, null!, null!, null!, null!,
            null!, null!, null!);
        RoleManagerMock = new Mock<RoleManager<Role>>(
            Mock.Of<IRoleStore<Role>>(), null!, null!, null!, null!);
        CurrentUserMock = new Mock<ICurrentUser>();
        LoggerUserMock = new Mock<ILogger<UserService>>();

        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });
        _mapperConfig = mappingConfig.CreateMapper();

        UserService = new UserService(UserManagerMock.Object, LoggerUserMock.Object, CurrentUserMock.Object, _mapperConfig, RoleManagerMock.Object);

        Fixture = new Fixture();
        Fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(b => Fixture.Behaviors.Remove(b));
        Fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        UnitOfWorkMock = new Mock<IUnitOfWork>();
        AssetRepositoryMock = new Mock<IAssetRepository>();
        LoggerAssetMock = new Mock<ILogger<AssetService>>();
        //AssetServiceMock = new AssetService(LoggerAssetMock.Object, UnitOfWorkMock.Object, CurrentUserMock.Object, UserManagerMock.Object);

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

