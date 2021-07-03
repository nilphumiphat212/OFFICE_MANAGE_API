using System.ComponentModel.DataAnnotations;

namespace office_manage_api.Models.Dto
{
    public record TokenDto
    {
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Role { get; set; }
        public bool Actived { get; set; }
    }
}