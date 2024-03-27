namespace Miriam.Application.Authentication.DTOs;

public class UserToken
{
    public string? AccessToken { get; set; }
    public string? Email { get; set; }
    public DateTimeOffset? Expiration { get; set; }
    public DateTimeOffset? CurrentTime { get; set; }
}