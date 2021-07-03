using System;

namespace office_manage_api.Models.EF
{
    public record User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string Role { get; set; }
        public string OrgRole { get; set; }
        public string OrgUnder { get; set; }
        public string ImageUrl { get; set; }
        public bool Active { get; set; }
    }
}