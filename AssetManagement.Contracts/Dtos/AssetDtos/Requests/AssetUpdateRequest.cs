using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AssetManagement.Domain.Enums;

namespace AssetManagement.Contracts.Dtos.AssetDtos.Requests
{
    public class AssetUpdateRequest
    {
        [Required]
        public Guid AssetId { get; set; }
        [Required]
        public string? AssetName { get; set; }
        [Required]
        public string? Specification { get; set; }
        [Required]
        public DateTime? InstalledDate { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [EnumDataType(typeof(AssetState))]
        public AssetState? State { get; set; }

    }
}