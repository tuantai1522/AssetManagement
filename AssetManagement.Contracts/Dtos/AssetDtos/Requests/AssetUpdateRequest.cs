using System.Text.Json.Serialization;
using AssetManagement.Domain.Enums;

namespace AssetManagement.Contracts.Dtos.AssetDtos.Requests
{
    public class AssetUpdateRequest
    {
        public Guid AssetId { get; set; }
        public string? AssetName { get; set; }
        public string? Specification { get; set; }
        public DateTime? InstalledDate { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AssetState? State { get; set; }

    }
}