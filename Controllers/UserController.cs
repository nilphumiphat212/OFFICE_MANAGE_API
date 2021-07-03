using Microsoft.AspNetCore.Mvc;
using office_manage_api.Services.Interfaces;

namespace office_manage_api.Controllers
{
    public class UserController : ControllerBase
    {
        private IUserService UserService { get; }
        public UserController(IUserService user)
        {
            this.UserService = user;
        }

        [HttpGet]
        [Route("api/user/get-all-users")]
        public IActionResult GetAllUSer()
        {
            return Ok(new { users = UserService.GetAllUsers() });
        }
    }
}