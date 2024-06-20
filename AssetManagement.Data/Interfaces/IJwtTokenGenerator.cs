using AssetManagement.Domain.Entities;

namespace AssetManagement.Data.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(AppUser user, List<string> roles);
    }
}