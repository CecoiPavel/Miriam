namespace Miriam.Application.Common.Authentication;

public class AuthenticationResult
{
    public string? AccessToken { get; set; }
    public DateTimeOffset? Expiration { get; set; }
    public DateTimeOffset? CurrentTime { get; set; }
}