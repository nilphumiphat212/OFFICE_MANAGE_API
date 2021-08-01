using System;

namespace office_manage_api.Models.Dto.Requests
{
    public record WorkingTimeRequest
    {
        public string Action { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public string Otp { get; set; }
        public string RequestBy { get; set; }
    }
}