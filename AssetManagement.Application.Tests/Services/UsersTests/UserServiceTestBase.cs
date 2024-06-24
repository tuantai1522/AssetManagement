using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Extensions;
using AssetManagement.Application.Services.Implementations;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Domain.Entities;
using AutoFixture;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Moq;

namespace AssetManagement.Application.Tests.Services.UsersTests;
public class UserServiceTestBase
{

    protected readonly Mock<UserManager<AppUser>> UserManagerMock;
    protected readonly Mock<ICurrentUser> CurrentUserMock;
    protected readonly IUserService UserService;
    protected readonly Mock<ILogger<UserService>> LoggerMock;
    protected readonly Fixture Fixture;
    protected readonly IMapper _mapperConfig;
    protected readonly Mock<RoleManager<Role>> RoleManagerMock;

    protected List<Role> Roles;

    protected List<AppUser> Users;

    public UserServiceTestBase()
    {
        UserManagerMock = new Mock<UserManager<AppUser>>(Mock.Of<IUserStore<AppUser>>(), null!, null!, null!, null!, null!,
            null!, null!, null!);

		RoleManagerMock = new Mock<RoleManager<Role>>(
            Mock.Of<IRoleStore<Role>>(), null!, null!, null!, null!);


		CurrentUserMock = new Mock<ICurrentUser>();

        LoggerMock = new Mock<ILogger<UserService>>();

        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });
        _mapperConfig = mappingConfig.CreateMapper();

        UserService = new UserService(UserManagerMock.Object, LoggerMock.Object, CurrentUserMock.Object, _mapperConfig, RoleManagerMock.Object);

        Fixture = new Fixture();
        Fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(b => Fixture.Behaviors.Remove(b));
        Fixture.Behaviors.Add(new OmitOnRecursionBehavior());

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
            FirstName = "Admin",
            LastName = "1",
            StaffCode = "SD0001",
            JoinedDate = DateTime.Now,
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
                FirstName = "Staff",
                LastName = i.ToString(),
                StaffCode = $"SD{i:D4}",
                JoinedDate = DateTime.Now.AddDays(i),
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
                FirstName = "Admin",
                LastName = "10",
                StaffCode = "SD0010",
                JoinedDate = DateTime.Now.AddHours(2),
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

