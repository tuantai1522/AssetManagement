using AssetManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Entities {
    public class ReturningRequest {
        [Key]
        public Guid Id { get; set; }

        public ReturningRequestState State { get; set; } = ReturningRequestState.WaitingForReturning;

        public DateTime? ReturnedDate { get; set; }

        public virtual Assignment Assignment { get; set; } = null!;
        public Guid AssignmentId { get; set; }

        public virtual AppUser RequestedByUser { get; set; } = null!;
        public Guid RequestedByUserId { get; set; }

        public virtual AppUser? AcceptedByUser { get; set; }
        public Guid? AcceptedByUserId { get; set; }

    }
}
