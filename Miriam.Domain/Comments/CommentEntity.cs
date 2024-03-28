using Miriam.Domain.Base;
using Miriam.Domain.Posts;

namespace Miriam.Domain.Comments;

public class CommentEntity : EntityFullAudited
{
    public string ParentCommentId { get; set; }
    public virtual CommentEntity Comment { get; set; }
    public virtual PostEntity PostEntity { get; set; }
}