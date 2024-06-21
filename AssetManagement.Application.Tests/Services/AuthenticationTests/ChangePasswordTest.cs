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
    public async Task ChangePassword_InvalidPassword_ThrowsBadRequestException()
    {
        // Arrange
        var request = new ChangePasswordRequest { UserId = Guid.NewGuid(), OldPassword = "oldpass", NewPassword = "short" };

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _authService.ChangePassword(request));
        Assert.Equal("Password must contain at least eight characters.", exception.Message);
    }

    [Fact]
    public async Task ChangePassword_UserNotFound_ThrowsNotFoundException()
    {
        // Arrange
        var request = new ChangePasswordRequest { UserId = Guid.NewGuid(), OldPassword = "oldpass", NewPassword = "NewPassword1!" };
        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync((AppUser)null);

        // Act & Assert
        var exception = await Assert.ThrowsAsync<NotFoundException>(() => _authService.ChangePassword(request));
        Assert.Equal("User not found!", exception.Message);
    }

    [Fact]
    public async Task ChangePassword_FirstPasswordChange_Success()
    {
        // Arrange
        var request = new ChangePasswordRequest { UserId = Guid.NewGuid(), OldPassword = "oldpass", NewPassword = "NewPassword1!" };
        var user = _fixture.Create<AppUser>();
        user.IsPasswordChanged = false;

        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _userManagerMock.Setup(um => um.GeneratePasswordResetTokenAsync(user)).ReturnsAsync("resetToken");
        _userManagerMock.Setup(um => um.ResetPasswordAsync(user, "resetToken", request.NewPassword)).ReturnsAsync(IdentityResult.Success);
        _userManagerMock.Setup(um => um.UpdateAsync(user)).ReturnsAsync(IdentityResult.Success);

        // Act
        var result = await _authService.ChangePassword(request);

        // Assert
        Assert.True(result);
        _userManagerMock.Verify(um => um.GeneratePasswordResetTokenAsync(user), Times.Once);
        _userManagerMock.Verify(um => um.ResetPasswordAsync(user, "resetToken", request.NewPassword), Times.Once);
        _userManagerMock.Verify(um => um.UpdateAsync(user), Times.Once);
    }

    [Fact]
    public async Task ChangePassword_RegularChangePassword_Success()
    {
        // Arrange
        var request = new ChangePasswordRequest { UserId = Guid.NewGuid(), OldPassword = "oldpass", NewPassword = "NewPassword1!" };
        var user = _fixture.Create<AppUser>();
        user.IsPasswordChanged = true;

        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _userManagerMock.Setup(um => um.ChangePasswordAsync(user, request.OldPassword, request.NewPassword)).ReturnsAsync(IdentityResult.Success);

        // Act
        var result = await _authService.ChangePassword(request);

        // Assert
        Assert.True(result);
        _userManagerMock.Verify(um => um.ChangePasswordAsync(user, request.OldPassword, request.NewPassword), Times.Once);
    }

    [Fact]
    public async Task ChangePassword_ChangePasswordFails_ThrowsBadRequestException()
    {
        // Arrange
        var request = new ChangePasswordRequest { UserId = Guid.NewGuid(), OldPassword = "oldpass", NewPassword = "NewPassword1!" };
        var user = _fixture.Create<AppUser>();
        user.IsPasswordChanged = true;

        var errorDescription = "Password change failed.";
        var identityError = new IdentityError { Description = errorDescription };

        _userManagerMock.Setup(um => um.FindByIdAsync(It.IsAny<string>())).ReturnsAsync(user);
        _userManagerMock.Setup(um => um.ChangePasswordAsync(user, request.OldPassword, request.NewPassword))
                        .ReturnsAsync(IdentityResult.Failed(identityError));

        // Act & Assert
        var exception = await Assert.ThrowsAsync<BadRequestException>(() => _authService.ChangePassword(request));
        Assert.Equal(errorDescription, exception.Message);
    }
}


