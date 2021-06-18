using Microsoft.AspNetCore.Mvc;
using office_manage_api.Services.Interfaces;
using Microsoft.Extensions.Options;
using office_manage_api.Configure;

namespace office_manage_api.Controllers
{
    public class AuthorizationController : ControllerBase
    {
        private AppSettings AppSettings { get; }
        private IJwtService Jwt { get; }

        public AuthorizationController(IOptions<AppSettings> appSettings, IJwtService jwt)
        {
            this.AppSettings = appSettings.Value;
            this.Jwt = jwt;
        }

        [HttpGet]
        [Route("api/test")]
        public IActionResult Test()
        {
            return Ok(new { status = 200, secrect = AppSettings.Jwt.Secret });
        }
    }
}