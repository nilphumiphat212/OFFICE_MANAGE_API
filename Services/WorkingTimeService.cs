using System.Linq;
using System.Collections.Generic;
using office_manage_api.Services.Interfaces;
using office_manage_api.Models.Dto;
using office_manage_api.Configure;
using Microsoft.Extensions.Options;

namespace office_manage_api.Services {
    public class WorkingTimeService : IWorkingTimeService {
        private AppSettings AppSettings { get; }
        private DatabaseContext Db { get; } 
        public WorkingTimeService(IOptions<AppSettings> appSettings, DatabaseContext db) {
            this.AppSettings = appSettings.Value;
            this.Db = db;
        }

        public void GetOtpFromClient(string otp) {

        }
        public OtpDisplayDto GetOtpDisplayData() {
            return new OtpDisplayDto {
                MinutesOfRefresh = AppSettings.OtpDisplay.MinutesOfRefresh,
                DisplayText = AppSettings.OtpDisplay.DisplayText
            };
        }

        public dynamic GetLists() {
            return Db.WorkingTimes.Select(s => s).ToList();
        }

    }
}