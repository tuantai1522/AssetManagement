using AssetManagement.Domain.Entities;
using AssetManagement.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace AssetManagement.Application.Extensions;

public class UserValidationMiddleware
{
    private readonly RequestDelegate _next;

    public UserValidationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, UserManager<AppUser> userManager)
    {
        if (context.User.Identity.IsAuthenticated)
        {
            var userId = context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!string.IsNullOrEmpty(userId))
            {
                var user = await userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    if (user.IsDisabled) throw new UnauthorizedException("Your account is disabled!");
                    var userRoles = await userManager.GetRolesAsync(user);
                    var currentRoleClaims = context.User.Claims.Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value).ToList();

                    if (!userRoles.SequenceEqual(currentRoleClaims))
                    {
                        var identity = context.User.Identity as ClaimsIdentity;
                        if (identity != null)
                        {
                            // Remove existing role claims
                            foreach (var roleClaim in currentRoleClaims)
                            {
                                identity.RemoveClaim(identity.FindFirst(c => c.Type == ClaimTypes.Role && c.Value == roleClaim));
                            }

                            // Add updated role claims
                            foreach (var role in userRoles)
                            {
                                identity.AddClaim(new Claim(ClaimTypes.Role, role));
                            }

                            // Refresh the user principal
                            context.User = new ClaimsPrincipal(identity);
                        }
                    }
                }
                else
                {
                    throw new UnauthorizedException("Can not find your account, please login again!");
                }
            }
        }

        await _next(context);
    }
}