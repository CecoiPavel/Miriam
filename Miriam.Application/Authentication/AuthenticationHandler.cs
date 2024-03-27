using System.IdentityModel.Tokens.Jwt;
using System.Text;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Miriam.Application.Authentication.Command;
using Miriam.Application.Authentication.DTOs;

namespace Miriam.Application.Authentication;

public class AuthenticationHandler(IConfiguration configuration)
    : IRequestHandler<AuthenticationCommand, UserToken>
{
    public Task<UserToken> Handle(AuthenticationCommand request, CancellationToken cancellationToken)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"] ?? string.Empty));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var jwtSecurityToken = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Issuer"],
            expires: DateTime.Now.AddMinutes(20), signingCredentials: credentials);

        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        var currentTime = DateTime.UtcNow;
        return Task.FromResult(new UserToken
        {
            AccessToken = token,
            Email = request.Email,
            CurrentTime = currentTime,
            Expiration = currentTime.AddMinutes(30)
        });
    }
}