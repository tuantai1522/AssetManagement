namespace AssetManagement.Contracts.Dtos.UserDtos.Responses;
public class FilterUserResponse
{
    public Guid Id { get; set; }
    public string StaffCode { get; set; } = null!;
    public string? FullName { get; set; }
    public string? Username { get; set; } = null!;
    public DateTime? JoinedDate { get; set; }
    public List<string?> Types { get; set; } = [];
}

