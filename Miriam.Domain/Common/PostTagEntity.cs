using Miriam.Domain.Base;
using Miriam.Domain.Posts;
using Miriam.Domain.Tag;

namespace Miriam.Domain.Common;

public class PostTagEntity : EntityFullAudited
{
    public string PostId { get; set; }
    public string TagId { get; set; }
    public virtual PostEntity Post { get; set; }
    public virtual TagEntity Tag { get; set; }
}