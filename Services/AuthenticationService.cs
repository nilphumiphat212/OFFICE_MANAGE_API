using office_manage_api.Services.Interfaces;

namespace office_manage_api.Services {
    public class AuthenticationService : IAuthenticationService {
        private IJwtService JwtService { get; }
        public AuthenticationService(IJwtService jwt) {
            this.JwtService = jwt;
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