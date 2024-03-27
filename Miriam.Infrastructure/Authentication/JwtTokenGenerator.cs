using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Miriam.Application.Authentication.DTOs;
using Miriam.Application.Common.Authentication;

namespace Miriam.Infrastructure.Authentication;

public class JwtTokenGenerator(IConfiguration configuration) : IJwtTokenGenerator
{
    public AuthenticationResult GenerateToken()
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"] ?? string.Empty));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var jwtSecurityToken = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Issuer"],
            expires: DateTime.Now.AddMinutes(20), signingCredentials: credentials);

        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        var currentTime = DateTime.UtcNow;
        
        return new AuthenticationResult
        {
            AccessToken = token,
            CurrentTime = currentTime,
            Expiration = currentTime.AddMinutes(30)
        };
    }
}