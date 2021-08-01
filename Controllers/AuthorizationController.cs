using Microsoft.AspNetCore.Mvc;
using office_manage_api.Services.Interfaces;
using Microsoft.Extensions.Options;
using office_manage_api.Configure;
using office_manage_api.Models.Dto;
using office_manage_api.Models.Dto.Request;
using office_manage_api.Models.Dto.Response;

namespace office_manage_api.Controllers
{
    public class AuthorizationController : ControllerBase
    {
        private AppSettings AppSettings { get; }
        private IAuthenticationService AuthService { get; }

        public AuthorizationController(IOptions<AppSettings> appSettings, IAuthenticationService AuthService)
        {
            this.AppSettings = appSettings.Value;
            this.AuthService = AuthService;
        }

        [HttpPost]
        [Route("api/authentication/login")]
        public ActionResult<UserResponse> Login([FromBody] LoginRequest data)
        {
            if (!string.IsNullOrEmpty(data.Username) && !string.IsNullOrEmpty(data.Password)) {
                UserResponse res = AuthService.CheckLogin(data);
                if (res != null) return res;
            }
            return Unauthorized();
        }

        [HttpGet]
        [Route("api/test")]
        public IActionResult Test()
        {
            TokenDto test = new TokenDto
            {
                Username = "nilphumiphat",
                Firstname = "Phumiphat",
                Lastname = "Jaroenyonwhatthana",
                Role = "admin",
                Actived = true
            };
            string token = "test";
            return Ok(new { status = 200, token });
        }
    }
}