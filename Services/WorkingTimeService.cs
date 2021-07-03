using office_manage_api.Services.Interfaces;
using office_manage_api.Models.Dto;
using office_manage_api.Configure;
using Microsoft.Extensions.Options;

namespace office_manage_api.Services {
    public class WorkingTimeService : IWorkingTimeService {
        private AppSettings AppSettings { get; } 
        public WorkingTimeService(IOptions<AppSettings> appSettings) {
            this.AppSettings = appSettings.Value;
        }

        public void GetOtpFromClient(string otp) {

        }
        public OtpDisplayDto GetOtpDisplayData() {
            return new OtpDisplayDto {
                MinutesOfRefresh = AppSettings.OtpDisplay.MinutesOfRefresh,
                DisplayText = AppSettings.OtpDisplay.DisplayText
            };
        }

    }
}