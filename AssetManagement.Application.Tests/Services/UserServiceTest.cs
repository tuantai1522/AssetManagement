using AssetManagement.Application.Common.Credential;
using AssetManagement.Application.Services.Implementations;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Entities;
using AutoFixture;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using MockQueryable.Moq;
using Moq;

namespace AssetManagement.Application.Tests.Service;
public class UserServiceTest
{

    private readonly Mock<UserManager<AppUser>> _userManagerMock;
    private readonly Mock<ICurrentUser> _currentUserMock;
    private readonly IUserService _userService;
    private readonly Mock<ILogger<UserService>> _loggerMock;
    private readonly Fixture _fixture;

    private List<Role> Roles;

    private List<AppUser> Users;

    public UserServiceTest()
    {
        _userManagerMock = new Mock<UserManager<AppUser>>(Mock.Of<IUserStore<AppUser>>(), null!, null!, null!, null!, null!,
            null!, null!, null!);
        _currentUserMock = new Mock<ICurrentUser>();
        _loggerMock = new Mock<ILogger<UserService>>();
        _userService = new UserService(_userManagerMock.Object, _loggerMock.Object, _currentUserMock.Object);

        _fixture = new Fixture();
        _fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(b => _fixture.Behaviors.Remove(b));
        _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

        Setup();
    }

    #region setup

    private void Setup()
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

    [Theory]
    [InlineData(1, null)]
    [InlineData(0, 6)]
    [InlineData(-1, 4)]
    [InlineData(1, 0)]
    [InlineData(1, -1)]
    [InlineData(null, 4)]
    public async Task FilterAsync_ShouldReturnDefaultPageSize_WhenPageSizeIsInvalid(int? page, int? size)
    {
        //Arrange
        var defaultSize = 5;
        var filter = new FilterUserRequest()
        {
            PageNumber = page,
            PageSize = size
        };

        var admin = _fixture.Build<AppUser>()
            .With(a => a.UserRoles,
            _fixture.Build<UserRole>()
            .With(ur => ur.Role,
            _fixture.Build<Role>()
            .With(r => r.Name, "Admin")
            .Create()).CreateMany(1).ToList()).Create();

        var mockData = _fixture.Build<AppUser>()
            .With(a => a.UserRoles,
            _fixture.Build<UserRole>()
            .With(ur => ur.Role,
            _fixture.Build<Role>()
            .With(r => r.Name, "Admin")
            .Create()).CreateMany(1).ToList()).CreateMany(8).ToList();

        var mock = mockData.AsQueryable().BuildMock();

        _currentUserMock.Setup(m => m.UserId)
            .Returns(admin.Id);

        _userManagerMock.Setup(m => m.Users)
            .Returns(mock);

        _userManagerMock.Setup(m => m.FindByIdAsync(admin.Id.ToString()))
            .ReturnsAsync(admin);

        //Act
        var result = await _userService.FilterUserAsync(filter);

        //Assert
        Assert.NotNull(result);
        Assert.Equal(mockData.Count(), result.TotalItemCount);
        Assert.Equal(defaultSize, result.Data.Count);
    }

    [Theory]
    [InlineData(SortOption.Asc, null, null, null, "Admin 1")]
    [InlineData(SortOption.Desc, null, null, null, "Staff 9")]
    [InlineData(null, SortOption.Asc, null, null, "Admin 1")]
    [InlineData(null, SortOption.Desc, null, null, "Staff 9")]
    [InlineData(null, null, SortOption.Asc, null, "Admin 1")]
    [InlineData(null, null, SortOption.Desc, null, "Admin 10")]
    [InlineData(null, null, null, SortOption.Asc, "Admin 1")]
    [InlineData(null, null, null, SortOption.Desc, "Staff 9")]
    public async Task FilterProductAsync_ShouldReturnCorrectSortOrder(
        SortOption? sortFullName,
        SortOption? sortJoinedDate,
        SortOption? sortStaffCode,
        SortOption? sortType,
        string expectedUserName)
    {
        //Arrange
        var filter = new FilterUserRequest()
        {
            PageNumber = 1,
            PageSize = 10,
            SortFullName = sortFullName,
            SortJoinedDate = sortJoinedDate,
            SortStaffCode = sortStaffCode,
            SortType = sortType
        };

        var mock = Users.AsQueryable().BuildMock();

        _currentUserMock.Setup(m => m.UserId)
            .Returns(Users[0].Id);

        _userManagerMock.Setup(m => m.Users)
            .Returns(mock);

        _userManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(Users[0]);

        //Act
        var result = await _userService.FilterUserAsync(filter);

        //Assert
        Assert.NotNull(result);
        Assert.Equal(expectedUserName, result.Data.First().FullName);
    }
}

