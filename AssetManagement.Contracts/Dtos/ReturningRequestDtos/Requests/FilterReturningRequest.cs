using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Enums;

namespace AssetManagement.Contracts.Dtos.ReturningRequestDtos.Requests {
    public class FilterReturningRequest {
        public string? Search { get; set; }
        public ReturningRequestState[]? States { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public SortOption? SortAssetCode { get; set; }
        public SortOption? SortAssetName { get; set; }
        public SortOption? SortRequestedBy { get; set; }
        public SortOption? SortAssignedDate { get; set; }
        public SortOption? SortAcceptedBy { get; set; }
        public SortOption? SortReturnedDate { get; set; }
        public SortOption? SortState { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}
