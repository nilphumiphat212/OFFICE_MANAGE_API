namespace office_manage_api.Models.EF
{
    public record Organization
    {
        public int ID { get; set; }
        public string Role { get; set; }
        public int Level { get; set; }
    }
}