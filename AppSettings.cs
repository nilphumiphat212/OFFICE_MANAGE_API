namespace office_manage_api.Configure
{
    public class AppSettings
    {
        public Jwt Jwt { get; set; }
    }
    public class Jwt
    {
        public string Secret { get; set; }
    }
}
