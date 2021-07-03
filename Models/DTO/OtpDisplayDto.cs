namespace office_manage_api.Models.Dto {
    public record OtpDisplayDto {
        public int MinutesOfRefresh { get; set; }
        public string DisplayText { get; set; }
    }
}