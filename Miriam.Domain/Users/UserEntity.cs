using Miriam.Domain.Base;
using Miriam.Domain.Common;
using Miriam.Domain.Posts;

namespace Miriam.Domain.Users;

public class UserEntity : EntityFullAudited, IUser
{
    public string? UserName { get; set; }
    public string Password { get; set; }
    public string? NormalizedUserName { get; set; }
    public virtual ICollection<PostEntity> Posts { get; set; }
}