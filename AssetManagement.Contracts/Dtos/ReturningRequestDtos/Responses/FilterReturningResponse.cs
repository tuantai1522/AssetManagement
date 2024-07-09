using AssetManagement.Domain.Enums;

namespace AssetManagement.Contracts.Dtos.ReturningRequestDtos.Responses {
    public class FilterReturningResponse {
        public Guid Id { get; set; }
        public string? AssetCode { get; set; }
        public string? AssetName { get; set; }
        public string? RequestedBy { get; set; }
        public DateTime? AssignedDate { get; set; }
        public string? AcceptedBy { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public ReturningRequestState? State { get; set; }
    }
}
