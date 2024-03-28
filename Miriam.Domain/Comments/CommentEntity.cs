using Miriam.Domain.Base;
using Miriam.Domain.Posts;

namespace Miriam.Domain.Comments;

public class CommentEntity : EntityFullAudited
{
    public string ParentCommentId { get; set; }
    public string PostId { get; set; }
    public virtual CommentEntity ParentComment { get; set; }
    public virtual PostEntity Post { get; set; }
}