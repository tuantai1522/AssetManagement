using AssetManagement.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Contracts.Dtos.AssetDtos.Requests;
public class AssetCreationRequest
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public Guid CategoryId { get; set; }
    [Required]
    public string Specification { get; set; } = string.Empty;
    [Required]
    public DateTime InstalledDate { get; set; }
    [Required]
    [EnumDataType(typeof(AssetState))]
    public AssetState State { get; set; }
}
