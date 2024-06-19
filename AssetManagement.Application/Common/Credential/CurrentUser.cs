using AssetManagement.Domain.Exceptions;
using System.Security.Claims;

namespace AssetManagement.Application.Common.Credential
{
    public class CurrentUser(IHttpContextAccessor context) : ICurrentUser
    {
        public bool IsAuthenticated => context.HttpContext?.User.Identity is { IsAuthenticated: true };

        public Guid UserId
        {
            get
            {
                var userId = context.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value
                             ?? context.HttpContext?.User.FindFirst("sub")?.Value;

                return Guid.TryParse(userId, out var result)
                    ? result
                    : throw new NotFoundException("User id could not be retrieve");
            }
        }
    }
}
