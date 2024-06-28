using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Enums;
using AutoFixture;
using MockQueryable.Moq;
using Moq;

namespace AssetManagement.Application.Tests.Services.UsersTests
{
    public class FilterUserAsyncTest : SetUpUserServiceTest
    {
        public FilterUserAsyncTest() : base()
        {
        }

        [Theory]
        [InlineData(1, null)]
        [InlineData(0, 6)]
        [InlineData(-1, 4)]
        [InlineData(1, 0)]
        [InlineData(1, -1)]
        [InlineData(null, 4)]
        public async Task FilterUsersAsync_ShouldReturnDefaultPageSize_WhenPageSizeIsInvalid(int? page, int? size)
        {
            //Arrange
            var defaultSize = 5;
            var filter = new FilterUserRequest()
            {
                PageNumber = page,
                PageSize = size
            };

            var admin = Fixture.Build<AppUser>()
                .With(a => a.Location, Location.HCM.ToString())
                .With(a => a.IsDisabled, false)
                .With(a => a.UserRoles,
                Fixture.Build<UserRole>()
                .With(ur => ur.Role,
                Fixture.Build<Role>()
                .With(r => r.Name, "Admin")
                .Create()).CreateMany(1).ToList()).Create();

            var mockData = Fixture.Build<AppUser>()
                .With(a => a.Location, Location.HCM.ToString())
                .With(a => a.IsDisabled, false)
                .With(a => a.UserRoles,
                Fixture.Build<UserRole>()
                .With(ur => ur.Role,
                Fixture.Build<Role>()
                .With(r => r.Name, "Admin")
                .Create()).CreateMany(1).ToList()).CreateMany(8).ToList();

            mockData.Add(admin);

            var mock = mockData.AsQueryable().BuildMock();

            CurrentUserMock.Setup(m => m.UserId)
                .Returns(admin.Id);

            UserManagerMock.Setup(m => m.Users)
                .Returns(mock);

            //Act
            var result = await UserService.FilterUserAsync(filter);

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
        [InlineData(null, null, null, SortOption.Desc, "Staff 2")]
        public async Task FilterUsersAsync_ShouldReturnCorrectSortOrder(
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

            CurrentUserMock.Setup(m => m.UserId)
                .Returns(Users[0].Id);

            UserManagerMock.Setup(m => m.Users)
                .Returns(mock);

            UserManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(Users[0]);

            //Act
            var result = await UserService.FilterUserAsync(filter);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(expectedUserName, result.Data.First().FullName);
        }
    }
}
