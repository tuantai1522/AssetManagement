using AssetManagement.Contracts.Enums;

namespace AssetManagement.Contracts.Dtos.UserDtos.Requests;

public class FilterUserRequestDto
{
    public string? Name { get; set; }
    public string[]? Types { get; set; }
    public SortOption? SortStaffCode { get; set; }
    public SortOption? SortFullName { get; set; }
    public SortOption? SortJoinedDate { get; set; }
    public SortOption? SortType { get; set; }
    public int? PageNumber { get; set; }
    public int? PageSize { get; set; }
}

