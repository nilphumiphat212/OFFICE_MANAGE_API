using Microsoft.AspNetCore.Mvc;
using office_manage_api.Services.Interfaces;

namespace office_manage_api.Controllers
{
    public class WorkingTimeController : ControllerBase
    {
        private IWorkingTimeService WorkingTimeService { get; }
        public WorkingTimeController(IWorkingTimeService workingtime)
        {
            this.WorkingTimeService = workingtime;
        }

        [HttpGet]
        [Route("api/workingtime/get-data")]
        public IActionResult GetData()
        {
            return Ok(new { data = WorkingTimeService.GetOtpDisplayData() });
        }
    }
}