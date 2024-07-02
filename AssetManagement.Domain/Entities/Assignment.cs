using AssetManagement.Domain.Enums;

namespace AssetManagement.Domain.Entities
{
    public class Assignment
    {
        public Guid Id { get; set; }
        public Guid AssetId { get; set; }
        public Guid AssignedToId { get; set; }
        public Guid AssignedById { get; set; }
        public string? Note { get; set; }
        public AssignmentState? State { get; set; }
        public DateTime AssignedDate { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public Asset? Asset { get; set; }
        public AppUser? AssignedToUser { get; set; }
        public AppUser? AssignedByUser { get; set; }
    }
}