using System;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using office_manage_api.Models.Dto;
using office_manage_api.Services.Interfaces;
using office_manage_api.Configure;

namespace office_manage_api.Services
{
    public class JwtService : IJwtService
    {
        private AppSettings AppSettings { get; }
        public JwtService(IOptions<AppSettings> appSettings)
        {
            this.AppSettings = appSettings.Value;
        }
        public string GenerateToken(TokenDto data)
        {
            byte[] secret = Encoding.ASCII.GetBytes(AppSettings.Jwt.Secret);
            JwtSecurityTokenHandler jwt = new JwtSecurityTokenHandler();
            SecurityTokenDescriptor tokenDesc = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(new Claim[] {
                  new Claim("username", data.Username),
                  new Claim("firstname", data.Firstname),
                  new Claim("lastname", data.Lastname),
                  new Claim("role", data.Role),
                  new Claim("Actived", data.Actived ? "yes" : "no")  
                }),
                Expires = DateTime.Now.AddDays(30),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken token = jwt.CreateToken(tokenDesc);
            return (string) jwt.WriteToken(token);
        }
    }
}