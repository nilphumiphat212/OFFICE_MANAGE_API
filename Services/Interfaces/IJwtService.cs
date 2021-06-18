using System;
using office_manage_api.Models.Dto;

namespace office_manage_api.Services.Interfaces
{
    public interface IJwtService
    {
        public string GenerateTokenFromLogin(LoginDto data);
    }
}