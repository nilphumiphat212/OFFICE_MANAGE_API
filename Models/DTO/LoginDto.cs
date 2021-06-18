namespace office_manage_api.Models.Dto {
    public record LoginDto {
        public string Username { get; set; }
        public string Password { get; set; }
        public string TempPassword { get; set; }
        public string SecureKey { get; set; }
    }
}