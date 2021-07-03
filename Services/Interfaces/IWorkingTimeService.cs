using office_manage_api.Models.Dto;

namespace office_manage_api.Services.Interfaces {
    public interface IWorkingTimeService {
        public void GetOtpFromClient(string otp);
        public OtpDisplayDto GetOtpDisplayData();
    }
}