using MediatR;
using Miriam.Application.Authentication.DTOs;

namespace Miriam.Application.Authentication.Command;

public class AuthenticationCommand : IRequest<UserToken>
{
    public string? Email { get; set; }
    public string? Password{ get; set; }
}