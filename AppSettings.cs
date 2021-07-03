namespace office_manage_api.Configure
{
    public class AppSettings
    {
        public Jwt Jwt { get; set; }
        public OtpDisplay OtpDisplay { get; set; }
    }
    public class Jwt
    {
        public string Secret { get; set; }
    }
    public class OtpDisplay
    {
        public int MinutesOfRefresh { get; set; }
        public string DisplayText { get; set; }
    }
}
