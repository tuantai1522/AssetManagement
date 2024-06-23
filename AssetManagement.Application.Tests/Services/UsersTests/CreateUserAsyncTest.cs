using AssetManagement.Application.Tests.Services.UsersTests;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Domain.Entities;
using AutoFixture;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MockQueryable.Moq;
using Moq;

namespace AssetManagement.Application.Tests.Services.UsersTests;
public class CreateUserAsyncTest : UserServiceTestBase
{
    public CreateUserAsyncTest() : base() { }

    public static readonly TheoryData<string, string, DateTime, DateTime, string, string> SuccessfulCreateCases =
    new()
    {
        { "Anh", "Nguyen Van", new DateTime(2000, 12, 1), new DateTime(2022, 1, 18), "Male", "Admin" },
        { "BINH", "NGUYEN VAN", new DateTime(1989, 6, 25), new DateTime(2020, 3, 20), "Male", "Staff" },
        { "cassie", "garcia", new DateTime(1999, 7, 21), new DateTime(2019, 11, 20), "Female", "Staff" },
    };

    [Theory, MemberData(nameof(SuccessfulCreateCases))]
    public async Task CreateUserAsync_SuccessfulCreation_ReturnsUserInfoResponse(string firstName, string lastName, 
        DateTime dateOfBirth, DateTime joinedDate, string gender, string type)
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = firstName,
            LastName = lastName,
            DateOfBirth = dateOfBirth,
            JoinedDate = joinedDate,
            Gender = gender,
            Type = type
        };

        RoleManagerMock.Setup(r => r.Roles).Returns(Roles.AsQueryable().BuildMockDbSet().Object);

        var mockData = Fixture.Build<AppUser>().CreateMany(8).ToList();

        UserManagerMock.Setup(x => x.Users).Returns(mockData.AsQueryable().BuildMock());
        UserManagerMock.Setup(x => x.CreateAsync(It.IsAny<AppUser>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Success);
        UserManagerMock.Setup(x => x.AddToRoleAsync(It.IsAny<AppUser>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Success);

        CurrentUserMock.Setup(m => m.UserId).Returns(mockData[0].Id);
        UserManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(mockData[0]);

        // Act
        var result = await UserService.CreateUserAsync(request);

        // Assert
        Assert.NotNull(result);
        //Assert.Equal(userInfoResponse, result);
        UserManagerMock.Verify(x => x.CreateAsync(It.IsAny<AppUser>(), It.IsAny<string>()), Times.Once);
        UserManagerMock.Verify(x => x.AddToRoleAsync(It.IsAny<AppUser>(), It.IsAny<string>()), Times.Once);
    }

    // [Fact]
    // public async Task CreateUserAsync_InvalidNumberOfWordsInFirstName_ThrowsBadRequestException()
    // {

    // }

    // [Fact]
    // public async Task CreateUserAsync_InvalidCharactersInFirstName_ThrowsBadRequestException()
    // {

    // }

    // [Fact]
    // public async Task CreateUserAsync_InvalidCharactersInLastName_ThrowsBadRequestException()
    // {

    // }

    // [Fact]
    // public async Task CreateUserAsync_InvalidRole_ThrowsBadRequestException()
    // {
    // }

    // [Fact]
    // public async Task CreateUserAsync_InvalidGender_ThrowsBadRequestException()
    // {
    // }

    // [Fact]
    // public async Task CreateUserAsync_InvalidGender_ThrowsBadRequestException()
    // {
    // }

    // [Fact]
    // public async Task CreateUserAsync_InvalidJoinedDateAsWeekend_ThrowsBadRequestException()
    // {
    // }

    // [Fact]
    // public async Task CreateUserAsync_InvalidJoinedDateRelateToDOB_ThrowsBadRequestException()
    // {
    // }
}
