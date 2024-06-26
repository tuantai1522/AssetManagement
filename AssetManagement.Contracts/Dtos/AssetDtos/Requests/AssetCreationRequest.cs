namespace AssetManagement.Contracts.Dtos.AssetDtos.Requests;
public class AssetCreationRequest
{
    public required string Name { get; set; }
    public Guid CategoryId { get; set; }
    public required string Specification { get; set; }
    public required DateTime InstalledDate { get; set; }
    public required string State { get; set; }
}
