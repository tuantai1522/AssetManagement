using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Domain.Entities
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public virtual AppUser User { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;

    }
}
