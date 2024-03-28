using Miriam.Domain.Base;
using Miriam.Domain.Posts;
using Miriam.Domain.Tag;

namespace Miriam.Domain.Common;

public class PostTagsEntity : EntityFullAudited
{
    public string PostId { get; set; }
    public string TagId { get; set; }
    public PostEntity Post { get; set; }
    public TagEntity Tag { get; set; }
}