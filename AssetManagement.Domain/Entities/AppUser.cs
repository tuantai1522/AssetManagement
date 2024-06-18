using AssetManagement.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Domain.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string StaffCode { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Location { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsPasswordChanged { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdatedDateTime { get; set; }

    }
}
