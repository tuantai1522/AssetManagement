using AssetManagement.Domain.Enums;

namespace AssetManagement.Contracts.Dtos.AssignmentDtos.Responses
{
    public class FilterAssignmentResponse
    {
        public Guid Id { get; set; }
        public string? AssetCode { get; set; }
        public string? AssetName { get; set; }
        public string? AssignedTo { get; set; }
        public string? AssignedBy { get; set; }
        public AssignmentState? State { get; set; }
        public DateTime? AssignedDate { get; set; }
    }
}
