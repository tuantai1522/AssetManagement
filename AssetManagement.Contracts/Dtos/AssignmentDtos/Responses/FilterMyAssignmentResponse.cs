using AssetManagement.Domain.Enums;

namespace AssetManagement.Contracts.Dtos.AssignmentDtos.Responses
{
    public class FilterMyAssignmentResponse
    {
        public Guid Id { get; set; }
        public string? AssetCode { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public DateTime AssignedDate { get; set; }
        public AssignmentState? State { get; set; }
    }
}
