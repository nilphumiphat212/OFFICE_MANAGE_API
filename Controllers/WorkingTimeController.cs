using Microsoft.AspNetCore.Mvc;
using office_manage_api.Services.Interfaces;
using office_manage_api.Models.Dto.Requests;

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

        [HttpPost]
        [Route("api/workingtime/checkin")]
        public ActionResult<WorkingTimeDto> Checkin([FromBody] WorkingTimeDto data)
        {
            return Ok(data);
        }

        [HttpPost]
        [Route("api/workingtime/checkout")]
        public ActionResult<WorkingTimeDto> Checkout([FromBody] WorkingTimeDto data)
        {
            return Ok(data);
        }

        [HttpGet]
        [Route("api/workingtime/get-lists")]
        public IActionResult GetLists()
        {
            return Ok();
        }

    }
}