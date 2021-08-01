namespace office_manage_api.Models.Dto.Request
{
    public record LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}