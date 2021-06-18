using System;
using office_manage_api.Models.Dto;
using office_manage_api.Services.Interfaces;

namespace office_manage_api.Services
{
    public class JwtService : IJwtService
    {
        public string GenerateTokenFromLogin(LoginDto loginData)
        {
            string token = null;
            return token;
        }
    }
}