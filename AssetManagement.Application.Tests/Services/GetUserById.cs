using AssetManagement.Application.Tests.Service;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using MockQueryable.Moq;

namespace AssetManagement.Application.Tests.Services
{
    public class GetUserById : UserServiceTestBase
    {
        public GetUserById() : base() { }
        [Fact]
        public async Task GetUser_ReturnOkAndUserInfo_WhenHasUser()
        {
            //Arrange
            AppUser userFocus = Fixture.Build<AppUser>()
               .With(a => a.UserRoles,
               Fixture.Build<UserRole>()
               .With(ur => ur.Role,
               Fixture.Build<Role>()
               .With(r => r.Name, "Admin")
               .Create()).CreateMany(1).ToList()).Create();
            Guid id = userFocus.Id;

            List<AppUser> userListMock = Fixture.Build<AppUser>()
                .With(a => a.UserRoles,
                Fixture.Build<UserRole>()
                .With(ur => ur.Role,
                Fixture.Build<Role>()
                .With(r => r.Name, "Staff")
                .Create()).CreateMany(1).ToList()).CreateMany(10).ToList();

            userListMock.Add(userFocus);
            var userQueryMock = userListMock.AsQueryable().BuildMock();
            UserManagerMock.Setup(m => m.Users).Returns(userQueryMock);

            //Act
            var result = await UserService.GetUserById(id);

            //Assert
            var actionResult = Assert.IsType<UserInfoResponse>(result);
            Assert.Equal(id, result.Id);
        }

        [Fact]
        public async Task GetUser_ReturnRightMessage_WhenNotFindingUser()
        {
            AppUser userFocus = Fixture.Build<AppUser>()
              .With(a => a.UserRoles,
              Fixture.Build<UserRole>()
              .With(ur => ur.Role,
              Fixture.Build<Role>()
              .With(r => r.Name, "Admin")
              .Create()).CreateMany(1).ToList()).Create();
            Guid id = userFocus.Id;

            List<AppUser> userListMock = Fixture.Build<AppUser>()
                .With(a => a.UserRoles,
                Fixture.Build<UserRole>()
                .With(ur => ur.Role,
                Fixture.Build<Role>()
                .With(r => r.Name, "Staff")
                .Create()).CreateMany(1).ToList()).CreateMany(10).ToList();

            var userQueryMock = userListMock.AsQueryable().BuildMock();
            UserManagerMock.Setup(m => m.Users).Returns(userQueryMock);

            //Act

            //Assert
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => UserService.GetUserById(id));
            Assert.Equal("User can not found", exception.Message);
        }
    }
}
