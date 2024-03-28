namespace Miriam.Application.Common.Authentication;

public interface IJwtTokenGenerator
{
    AuthenticationResult GenerateToken();
}