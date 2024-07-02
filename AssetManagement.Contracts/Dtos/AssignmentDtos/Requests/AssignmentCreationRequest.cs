using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Contracts.Dtos.AssignmentDtos.Requests;
public class AssignmentCreationRequest
{
    [Required]
    public Guid UserId { get; set; }
    [Required]
    public Guid AssetId { get; set; }
    [Required]
    [PastDate(ErrorMessage = "Assigned date must not be in the past.")]
    public DateTime AssignedDate { get; set; }
    [Required]
    public string Note { get; set; } = string.Empty;
}

public class PastDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        DateTime dateTime = (DateTime)value;
        return dateTime >= DateTime.Now;
    }
}