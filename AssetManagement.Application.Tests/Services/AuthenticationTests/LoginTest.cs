using AssetManagement.Contracts.Dtos.AuthDtos.Requests;
using AssetManagement.Contracts.Dtos.LoginDtos;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using AutoFixture;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Application.Tests.Services.AuthenticationTests
{
    public class LoginTest : SetupAuthenticationServiceTest
    {
        public LoginTest()
        {

        }

        [Fact]
        public async Task Login_UsernameIsEmpty_ThrowsBadRequestException()
        {
            // Arrange
            var request = new LoginRequest 
            { 
                Username = "", 
                Password = Guid.NewGuid().ToString()
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<BadRequestException>(() => _authService.Login(request));
            Assert.Equal("Please provide username and password to login", exception.Message);
        }

        [Fact]
        public async Task Login_PasswordIsEmpty_ThrowsBadRequestException()
        {
            // Arrange
            var request = new LoginRequest
            {
                Username = Guid.NewGuid().ToString(),
                Password = ""
            };

            // Act & Assert
            var exception = await Assert.ThrowsAsync<BadRequestException>(() => _authService.Login(request));
            Assert.Equal("Please provide username and password to login", exception.Message);
        }

        [Fact]
        public async Task Login_UserIsNotFound_ThrowsNotFoundException()
        {
            // Arrange
            var request = new LoginRequest
            {
                Username = Guid.NewGuid().ToString(),
                Password = Guid.NewGuid().ToString(),
            };

            _userManagerMock.Setup(um => um.FindByNameAsync(It.IsAny<string>())).ReturnsAsync((AppUser)null);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _authService.Login(request));
            Assert.Equal("Username or password is incorrect. Please try again", exception.Message);
        }

        [Fact]
        public async Task Login_UsernameOrPasswordIsNotValid_ThrowsUnauthorizedException()

        {
            // Arrange
            var request = new LoginRequest
            {
                Username = Guid.NewGuid().ToString(),
                Password = Guid.NewGuid().ToString(),
            };

            var user = _fixture.Create<AppUser>();
            _userManagerMock.Setup(um => um.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(user);

            _userManagerMock.Setup(um => um.CheckPasswordAsync(It.IsAny<AppUser>(), It.IsAny<string>()))
                                                                 .ReturnsAsync(false);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<UnauthorizedException>(() => _authService.Login(request));
            Assert.Equal("Username or password is incorrect. Please try again", exception.Message);
        }

        [Fact]
        public async Task Login_UserIsDisabled_ThrowsNotFoundException()
        {
            // Arrange
            var request = new LoginRequest
            {
                Username = Guid.NewGuid().ToString(),
                Password = Guid.NewGuid().ToString(),
            };

            var user = _fixture.Create<AppUser>();

            _userManagerMock.Setup(um => um.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(user);

            _userManagerMock.Setup(um => um.CheckPasswordAsync(It.IsAny<AppUser>(), It.IsAny<string>()))
                                                                 .ReturnsAsync(true);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<NotFoundException>(() => _authService.Login(request));
            Assert.Equal("Your account is disabled. Please contact with IT Team", exception.Message);
        }

        [Fact]
        public async Task Login_UsernameAndPasswordAreValid_ReturnsLoginResponse()
        {
            // Arrange
            var request = new LoginRequest
            {
                Username = Guid.NewGuid().ToString(),
                Password = Guid.NewGuid().ToString(),
            };

            var user = _fixture.Create<AppUser>();
            user.IsDisabled = false;

            _userManagerMock.Setup(um => um.FindByNameAsync(It.IsAny<string>())).ReturnsAsync(user);

            _userManagerMock.Setup(um => um.CheckPasswordAsync(It.IsAny<AppUser>(), It.IsAny<string>()))
                                                                 .ReturnsAsync(true);

            var roles = new List<string> { Guid.NewGuid().ToString()};
            _userManagerMock.Setup(um => um.GetRolesAsync(It.IsAny<AppUser>())).ReturnsAsync(roles);

            var generatedToken = Guid.NewGuid().ToString();
            _tokenGeneratorMock.Setup(tg => tg.GenerateToken(It.IsAny<AppUser>(), It.IsAny<List<string>>()))
                               .Returns(generatedToken);

            // Act
            var response = await _authService.Login(request);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(user.IsPasswordChanged, response.IsPasswordChanged);
            Assert.Equal(generatedToken, response.Token);
        }
    }
}
