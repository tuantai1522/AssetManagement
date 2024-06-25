namespace AssetManagement.Contracts.Dtos.AssetDtos.Responses;
public class AssetResponse
{
    public Guid Id { get; set; }
    public string AssetCode { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string CategoryName { get; set; } = string.Empty;
    public string Specification { get; set; } = string.Empty;
    public DateTime InstalledDate { get; set; }
    public string State { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime LastUpdated { get; set; }
}
