using System;

namespace office_manage_api.Models.EF
{
    public record WorkingTimeOtp
    {
        public int ID { get; set; }
        public int Otp { get; set; }
        public DateTime GenerateDate { get; set; }
    }
}