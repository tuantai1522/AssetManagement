using AssetManagement.Application.Common.Constants;
using AssetManagement.Contracts.Dtos.UserDtos.Responses;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace AssetManagement.Application.Tests.Services.UsersTests
{
    public class DisableUserAsyncTest : SetUpUserServiceTest
    {
        [Fact]
        public async Task DisableUserAsync_UserFoundAndDisabled_ReturnsDisableUserResponse()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var user = Fixture.Build<AppUser>().Create();
            UserManagerMock.Setup(um => um.FindByIdAsync(userId.ToString())).ReturnsAsync(user);
            UserManagerMock.Setup(um => um.UpdateAsync(user)).ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await UserService.DisableUserAsync(userId);

            // Assert
            Assert.NotNull(result);
            Assert.IsType<DisableUserResponse>(result);
            Assert.True(user.IsDisabled);
        }

        [Fact]
        public async Task DisableUserAsync_UserNotFound_ThrowsNotFoundException()
        {
            // Arrange
            var userId = Guid.NewGuid();
            UserManagerMock.Setup(um => um.FindByIdAsync(userId.ToString())).ReturnsAsync((AppUser?)null);

            // Act
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => UserService.DisableUserAsync(userId));

            //Assert
            Assert.Equal(ErrorStrings.USER_NOT_FOUND, exception.Message);
        }

        [Fact]
        public async Task DisableUserAsync_UpdateFails_ThrowsException()
        {
            // Arrange
            var userId = Guid.NewGuid();
            var user = Fixture.Build<AppUser>().Create();
            var errorDesc = "Update failed";
            var identityError = new IdentityError { Description = errorDesc };
            var identityResult = IdentityResult.Failed(identityError);
            UserManagerMock.Setup(um => um.FindByIdAsync(userId.ToString())).ReturnsAsync(user);
            UserManagerMock.Setup(um => um.UpdateAsync(user)).ReturnsAsync(identityResult);

            // Act
            var exception = await Assert.ThrowsAsync<Exception>(() => UserService.DisableUserAsync(userId));

            //Assert
            Assert.Equal(errorDesc, exception.Message);
        }
    }
}
