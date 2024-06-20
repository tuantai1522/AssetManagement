using AssetManagement.Contracts.Dtos.AuthDtos.Requests;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace AssetManagement.Application.Tests.Services.AuthenticationTests;
public class ChangePasswordTest : SetupAuthenticationServiceTest
{
    public ChangePasswordTest()
    {

    }

    [Fact]
    public async Task ChangePassword_UserNotFound_ThrowsNotFoundException()
    {
        // Arrange
        var request = new ChangePasswordRequest { UserId = Guid.NewGuid(), OldPassword = "oldpass", NewPassword = "newpass" };

        var userManagerMock = _fixture.Freeze<Mock<UserManager<AppUser>>>();

        userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>()))
                       .ReturnsAsync((AppUser)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() => _authService.ChangePassword(request));
        Assert.Equal("User not found!", exception.Message);
    }

    [Fact]
    public async Task ChangePassword_InvalidPassword_ThrowsBadRequestException()
    {
        // Arrange
        var request = new ChangePasswordRequest { UserId = Guid.NewGuid(), OldPassword = "oldpass", NewPassword = "newpass" };
        var user = _fixture.Create<AppUser>();

        var userManagerMock = _fixture.Freeze<Mock<UserManager<AppUser>>>();

        userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        userManagerMock.Setup(um => um.ChangePasswordAsync(user, request.OldPassword, request.NewPassword))
                       .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Invalid password" }));

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _authService.ChangePassword(request));
        Assert.Equal("Invalid password", exception.Message);
    }

    [Fact]
    public async Task ChangePassword_ValidRequest_ReturnsTrue()
    {
        // Arrange
        var request = new ChangePasswordRequest { UserId = Guid.NewGuid(), OldPassword = "oldpass", NewPassword = "newpass" };
        var user = _fixture.Create<AppUser>();

        var userManagerMock = _fixture.Freeze<Mock<UserManager<AppUser>>>();

        userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        userManagerMock.Setup(um => um.ChangePasswordAsync(user, request.OldPassword, request.NewPassword))
                       .ReturnsAsync(IdentityResult.Success);

        // Act
        var result = await _authService.ChangePassword(request);

        // Assert
        Assert.True(result);
    }
}


