using System;

namespace office_manage_api.Models.Dto.Requests
{
    public record WorkingTimeDto
    {
        public string Action { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public string RequestBy { get; set; }
    }
}