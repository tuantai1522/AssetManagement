using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Enums;

namespace AssetManagement.Contracts.Dtos.AssignmentDtos.Requests
{
    public class FilterAssignmentRequest
    {
        public string? Search { get; set; }
        public AssignmentState[]? States { get; set; }
        public DateTime? AssignedDate { get; set; }
        public SortOption? SortAssetCode { get; set; }
        public SortOption? SortAssetName { get; set; }
        public SortOption? SortAssignedTo { get; set; }
        public SortOption? SortAssignedBy { get; set; }
        public SortOption? SortAssignedDate { get; set; }
        public SortOption? SortState { get; set; }
        public SortOption? SortLastUpdate { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}
