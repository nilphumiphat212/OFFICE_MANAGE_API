using System.Linq;
using office_manage_api.Models.EF;
using office_manage_api.Services.Interfaces;
using office_manage_api.Models.Dto;
using office_manage_api.Models.Dto.Request;
using office_manage_api.Models.Dto.Response;

namespace office_manage_api.Services {
    public class AuthenticationService : IAuthenticationService {
        private IJwtService JwtService { get; }
        private DatabaseContext db { get; }
        public AuthenticationService(IJwtService jwt, DatabaseContext db) {
            this.JwtService = jwt;
            this.db = db;
        }
        public UserResponse CheckLogin(LoginRequest data) {
            User user = db.Users.Where(w => w.Username == data.Username && w.Password == data.Password && w.Active).FirstOrDefault();
            if (user != null) {
                string token = JwtService.GenerateToken(new TokenDto{
                    Username = data.Username,
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Role = user.Role,
                    Actived = user.Active
                });
                UserResponse result = new UserResponse {
                    ID = user.ID,
                    Username = user.Username,
                    FirstName = user.Firstname,
                    LastName = user.Lastname,
                    CreateBy = user.CreateBy,
                    CreateDate = user.CreateDate,
                    Role = user.Role,
                    OrgRole = user.OrgRole,
                    OrgUnder = user.OrgUnder,
                    ImageUrl = user.ImageUrl,
                    Token = token,
                    Active = user.Active
                };
                return result;
            }
            return null;
        }
        public string GetTokenFromLogin(string username, string password) {
            return null;
        }
        public bool Register() {
            return false;
        }
        public bool ForgotPassword(string userOrEmail) {
            return false;
        }
    }
}