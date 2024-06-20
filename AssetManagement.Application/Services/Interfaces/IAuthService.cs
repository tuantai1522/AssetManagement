using AssetManagement.Contracts.Dtos.LoginDtos;

namespace AssetManagement.Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}