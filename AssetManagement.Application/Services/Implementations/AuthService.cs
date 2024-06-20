using AssetManagement.Application.Services.Interfaces;
using AssetManagement.Contracts.Dtos.AuthDtos.Requests;
using AssetManagement.Contracts.Dtos.LoginDtos;
using AssetManagement.Data.Interfaces;
using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Application.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IJwtTokenGenerator _tokenGenerator;
        public AuthService(UserManager<AppUser> userManager, IJwtTokenGenerator tokenGenerator)
        {
            _userManager = userManager;
            _tokenGenerator = tokenGenerator;
        }
        public async Task<LoginResponse> Login(LoginRequest request)
        {
            if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
                throw new BadRequestException("Please provide username and password to login");

            var user = await _userManager.FindByNameAsync(request.Username);

            if (user is null)
                throw new NotFoundException("Username or password is incorrect. Please try again");

            if (user.IsDisabled)
                throw new NotFoundException("Your account is disabled. Please contact with IT Team");

            var check = await _userManager.CheckPasswordAsync(user, request.Password);
            if (check == false)
                throw new UnauthorizedException("Username or password is incorrect. Please try again");


            var roles = await _userManager.GetRolesAsync(user);
            var accessToken = _tokenGenerator.GenerateToken(user, roles.ToList());

            var response = new LoginResponse()
            {
                IsPasswordChanged = user.IsPasswordChanged,
                Token = accessToken,
            };
            return response;

        }

        public async Task<bool> ChangePassword(ChangePasswordRequest request)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            if (user == null)
            {
                throw new NotFoundException("User not found!");
            }
            var result = new IdentityResult();
            if (!user.IsPasswordChanged)
            {
                //First change password
                var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                result = await _userManager.ResetPasswordAsync(user, resetToken, request.NewPassword);
                //Update isPasswordChanged
                user.IsPasswordChanged = true;
                await _userManager.UpdateAsync(user);
            }
            else
            {
                result = await _userManager.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);
            }

            if (!result.Succeeded)
            {
                throw new BadRequestException(result.Errors.FirstOrDefault()?.Description);
            }
            return true;
        }
    }
}