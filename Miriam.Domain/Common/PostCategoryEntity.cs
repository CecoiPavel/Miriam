using Miriam.Domain.Base;
using Miriam.Domain.Categories;
using Miriam.Domain.Posts;

namespace Miriam.Domain.Common;

public class PostCategoryEntity : EntityFullAudited
{
    public string PostId { get; set; }
    public string CategoryId { get; set; }
    public virtual PostEntity Post { get; set; }
    public virtual CategoryEntity Category { get; set; }
}