using AssetManagement.Application.Common;
using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AuthDtos.Requests;
using AssetManagement.Contracts.Dtos.LoginDtos;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("LoginUser")]
        public async Task<ActionResult<LoginResponse>> LoginUser(LoginRequest request)
        {
            var data = await _authService.Login(request);

            var result = new BaseResult<LoginResponse>()
            {
                IsSuccess = true,
                Error = null,
                Result = data
            };
            return Ok(result);
        }

        [HttpPost("ChangePassword")]
        public async Task<ActionResult<LoginResponse>> ChangePassword(ChangePasswordRequest request)
        {
            var data = await _authService.ChangePassword(request);

            var result = new BaseResult<LoginResponse>()
            {
                IsSuccess = true,
                Error = null
            };
            return Ok(result);
        }
    }
}