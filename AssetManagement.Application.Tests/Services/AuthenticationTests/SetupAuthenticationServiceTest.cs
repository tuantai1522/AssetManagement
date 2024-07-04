using AssetManagement.Application.Services.Implementations;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AutoFixture;
using AutoFixture.AutoMoq;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace AssetManagement.Application.Tests.Services.AuthenticationTests;
public class SetupAuthenticationServiceTest : SetupTest
{
    protected IAuthService _authService;
    protected readonly Mock<IJwtTokenGenerator> _tokenGeneratorMock;

    public SetupAuthenticationServiceTest() : base()
    {
        _tokenGeneratorMock = _fixture.Freeze<Mock<IJwtTokenGenerator>>();
        _authService = new AuthService(_userManagerMock.Object, _tokenGeneratorMock.Object);
    }
}
