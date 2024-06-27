namespace AssetManagement.Contracts.Dtos.AssetDtos.Responses;
public class FilterAssetResponse
{
    public Guid Id { get; set; }
	public string? AssetCode { get; set; }
	public string? Name { get; set; }
	public string? Category { get; set; }
	public string? State { get; set; }
}

