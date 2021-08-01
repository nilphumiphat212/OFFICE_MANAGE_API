using System;
using office_manage_api.Models.Dto.Request;
using office_manage_api.Models.Dto.Response;

namespace office_manage_api.Services.Interfaces {
    public interface IAuthenticationService {
        public string GetTokenFromLogin(string username, string password);
        public UserResponse CheckLogin(LoginRequest data);
        public bool Register();
        public bool ForgotPassword(string userOrEmail);
    }
}