using Microsoft.AspNetCore.Identity;
using Miriam.Domain.Common;

namespace Miriam.Infrastructure.Authentication;

public class AuthenticationUser : IdentityUser<Guid>, IUser
{
    public string Password { get; set; }
}