using System;

namespace office_manage_api.Models.Dto
{
    public record WorkingTimeDto
    {
        public string Action { get; set; }
        public DateTime Time { get; set; }
        public string RequestBy { get; set; }
    }
}