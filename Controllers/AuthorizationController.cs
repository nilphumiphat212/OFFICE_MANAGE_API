using Microsoft.AspNetCore.Mvc;
using office_manage_api.Services.Interfaces;
using Microsoft.Extensions.Options;
using office_manage_api.Configure;
using office_manage_api.Models.Dto;

namespace office_manage_api.Controllers
{
    public class AuthorizationController : ControllerBase
    {
        private AppSettings AppSettings { get; }
        private IJwtService JwtService { get; }

        public AuthorizationController(IOptions<AppSettings> appSettings, IJwtService jwt)
        {
            this.AppSettings = appSettings.Value;
            this.JwtService = jwt;
        }

        [HttpGet]
        [Route("api/test")]
        public IActionResult Test()
        {
            TokenDto test = new TokenDto {
                Username = "nilphumiphat",
                Firstname = "Phumiphat",
                Lastname = "Jaroenyonwhatthana",
                Role = "admin",
                Actived = true
            };
            string token = JwtService.GenerateToken(test);
            return Ok(new { status = 200, token });
        }
    }
}