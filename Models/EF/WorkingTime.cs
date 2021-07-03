using System;

namespace office_manage_api.Models.EF
{
    public record WorkingTime
    {
        public int ID { get; set; }
        public string CheckinBy { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public int ChckinOtp { get; set; }
        public int CheckoutOtp { get; set; }
    }
}