using AssetManagement.Contracts.Enums;

namespace AssetManagement.Contracts.Dtos.AssignmentDtos.Requests
{
    public class FilterMyAssignmentRequest
    {
        public SortOption? SortAssetCode { get; set; }
        public SortOption? SortAssetName { get; set; }
        public SortOption? SortCategory { get; set; }
        public SortOption? SortAssignedDate { get; set; }
        public SortOption? State { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }

    }
}
