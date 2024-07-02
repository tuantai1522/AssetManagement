using AssetManagement.Domain.Enums;

namespace AssetManagement.Domain.Entities
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string? AssetCode { get; set; }
        public Guid CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Specification { get; set; }
        public AssetState? State { get; set; }
        public DateTime? InstalledDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string? Location { get; set; }

        public Category? Category { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; } = [];

    }
}
