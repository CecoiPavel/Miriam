using Miriam.Domain.Base;
using Miriam.Domain.Common;

namespace Miriam.Domain.Categories;

public class CategoryEntity : EntityFullAudited
{
    public string Title { get; set; }
    public string Description { get; set; }
    public virtual ICollection<PostCategoriesEntity> Posts { get; set; }
}