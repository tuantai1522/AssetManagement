using AssetManagement.Application.Common.Constants;
using AssetManagement.Application.Tests.Services.UsersTests;
using AssetManagement.Contracts.Dtos.UserDtos.Requests;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
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
        { "joNAthAn", "nGuYEN", new DateTime(1999, 7, 21), new DateTime(2019, 11, 20), "Male", "Admin" },
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
        RoleManagerMock.Setup(m => m.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(Roles.Find(r => r.Name == request.Type));

        var mockData = Fixture.Build<AppUser>().CreateMany(8).ToList();
        var firstUserWithSameUsername = new AppUser { UserName = "anhnv" };
        var secondUserWithSameUsername = new AppUser { UserName = "anhnv1" };
        var thirdUserWithSameUsername = new AppUser { UserName = "binhnv" };
        mockData.Add(firstUserWithSameUsername);
        mockData.Add(secondUserWithSameUsername);
        mockData.Add(thirdUserWithSameUsername);

        UserManagerMock.Setup(x => x.Users).Returns(mockData.AsQueryable().BuildMock());
        UserManagerMock.Setup(x => x.CreateAsync(It.IsAny<AppUser>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Success)
            .Verifiable();
        UserManagerMock.Setup(x => x.UpdateAsync(It.IsAny<AppUser>()))
            .ReturnsAsync(IdentityResult.Success)
            .Verifiable();

        CurrentUserMock.Setup(m => m.UserId).Returns(mockData[0].Id);
        UserManagerMock.Setup(m => m.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(mockData[0]);

        // Act
        var result = await UserService.CreateUserAsync(request);

        // Assert
        Assert.NotNull(result);
        UserManagerMock.Verify(x => x.CreateAsync(It.IsAny<AppUser>(), It.IsAny<string>()), Times.Once);
        UserManagerMock.Verify(x => x.UpdateAsync(It.IsAny<AppUser>()), Times.Once);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidNumberOfWordsInFirstName_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Invalid firtname",
            LastName = "Last name",
            DateOfBirth = new DateTime(2001, 7, 1),
            JoinedDate = new DateTime(2024, 6, 24),
            Gender = "Male",
            Type = "Staff"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_FIRSTNAME_NUMBER_OF_WORDS, exception.Message);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidCharactersInFirstName_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Firstname1",
            LastName = "Last name",
            DateOfBirth = new DateTime(2001, 7, 1),
            JoinedDate = new DateTime(2024, 6, 24),
            Gender = "Male",
            Type = "Staff"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_FIRSTNAME_CHARACTERS, exception.Message);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidCharactersInLastName_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Firstname",
            LastName = "Last name1",
            DateOfBirth = new DateTime(2001, 7, 1),
            JoinedDate = new DateTime(2024, 6, 24),
            Gender = "Male",
            Type = "Staff"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_LASTNAME_CHARACTERS, exception.Message);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidRole_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Firstname",
            LastName = "Last name",
            DateOfBirth = new DateTime(2001, 7, 1),
            JoinedDate = new DateTime(2024, 6, 24),
            Gender = "Male",
            Type = "Invalid"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_ROLE, exception.Message);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidGender_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Firstname",
            LastName = "Last name",
            DateOfBirth = new DateTime(2001, 7, 1),
            JoinedDate = new DateTime(2024, 6, 24),
            Gender = "Invalid",
            Type = "Staff"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_GENDER, exception.Message);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidDateOfBirthLowerThanMinimum_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Firstname",
            LastName = "Last name",
            DateOfBirth = new DateTime(2020, 7, 1),
            JoinedDate = new DateTime(2024, 6, 24),
            Gender = "Male",
            Type = "Staff"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_DATE_OF_BIRTH, exception.Message);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidDateOfBirthInFuture_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Firstname",
            LastName = "Last name",
            DateOfBirth = new DateTime(2100, 7, 1),
            JoinedDate = new DateTime(2024, 6, 24),
            Gender = "Male",
            Type = "Staff"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_DATE_OF_BIRTH_IN_FUTURE, exception.Message);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidJoinedDateAsWeekend_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Firstname",
            LastName = "Last name",
            DateOfBirth = new DateTime(2001, 7, 1),
            JoinedDate = new DateTime(2024, 6, 23),
            Gender = "Male",
            Type = "Staff"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_JOINED_DATE_RELATE_TO_WEEKDAY, exception.Message);
    }

    [Fact]
    public async Task CreateUserAsync_InvalidJoinedDateRelateToDOB_ThrowsBadRequestException()
    {
        // Arrange
        var request = new CreateUserRequest
        {
            FirstName = "Firstname",
            LastName = "Last name",
            DateOfBirth = new DateTime(2001, 7, 1),
            JoinedDate = new DateTime(2016, 6, 23),
            Gender = "Male",
            Type = "Staff"
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

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => UserService.CreateUserAsync(request));
        Assert.Equal(ErrorStrings.INVALID_JOINED_DATE_RELATE_TO_DOB, exception.Message);
    }
}
