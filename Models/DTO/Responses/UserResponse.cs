using System;

namespace office_manage_api.Models.Dto.Response
{
    public record UserResponse
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string Role { get; set; }
        public string OrgRole { get; set; }
        public string OrgUnder { get; set; }
        public string ImageUrl { get; set; }
        public string Token { get; set; }
        public bool Active { get; set; }
    }
}