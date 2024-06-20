namespace AssetManagement.Contracts.Dtos.LoginDtos
{
    public class LoginResponse
    {
        public bool IsPasswordChanged { get; set; }
        public string? Token { get; set; }
    }
}