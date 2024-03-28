using Miriam.Domain.Base;
using Miriam.Domain.Common;

namespace Miriam.Domain.Tag;

public class TagEntity : EntityFullAudited
{
    public string Title { get; set; }
    public string Description { get; set; }
    public virtual ICollection<PostTagsEntity> Posts { get; set; }
}