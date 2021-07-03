using System;

namespace office_manage_api.Services.Interfaces {
    public interface IAuthenticationService {
        public string GetTokenFromLogin(string username, string password);
        public bool Register();
        public bool ForgotPassword(string userOrEmail);
    }
}