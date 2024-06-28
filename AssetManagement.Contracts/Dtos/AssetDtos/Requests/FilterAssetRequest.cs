using AssetManagement.Contracts.Enums;
using AssetManagement.Domain.Enums;
namespace AssetManagement.Contracts.Dtos.AssetDtos.Requests;

public class FilterAssetRequest
{
    public string? Search { get; set; }
    public AssetState[]? States { get; set; }
    public string[]? Categories { get; set; }
    public SortOption? SortAssetCode { get; set; }
    public SortOption? SortAssetName { get; set; }
    public SortOption? SortCategory { get; set; }
    public SortOption? SortState { get; set; }
    public SortOption? SortLastUpdate { get; set; }
    public int? PageNumber { get; set; }
    public int? PageSize { get; set; }
}

