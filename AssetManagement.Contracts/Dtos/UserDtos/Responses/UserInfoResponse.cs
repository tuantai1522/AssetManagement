namespace AssetManagement.Contracts.Dtos.UserDtos.Responses
{
    public class UserInfoResponse
    {
        public Guid Id { get; set; }
        public string StaffCode { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string? Location { get; set; } = string.Empty;
        public DateTime? JoinedDate { get; set; }
        public string? Type { get; set; }
    }
}
