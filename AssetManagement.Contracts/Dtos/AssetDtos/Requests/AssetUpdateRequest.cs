namespace AssetManagement.Contracts.Dtos.AssetDtos.Requests
{
    public class AssetUpdateRequest
    {
        public Guid Id { get; set; }
        public string? AssetName { get; set; }
        public string? Specification { get; set; }
        public DateTime? InstalledDate { get; set; }
        public string? State { get; set; }

    }
}