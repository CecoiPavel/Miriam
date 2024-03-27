using Miriam.Domain.Common;

namespace Miriam.Domain.Users;

public class User : IUser
{
    public string? UserName { get; set; }
    public string Password { get; set; }
    public string? NormalizedUserName { get; set; }
}