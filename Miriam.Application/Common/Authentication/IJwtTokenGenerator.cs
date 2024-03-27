using Miriam.Application.Authentication.DTOs;

namespace Miriam.Application.Common.Authentication;

public interface IJwtTokenGenerator
{
    AuthenticationResult GenerateToken();
}