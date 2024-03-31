using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Comments;

namespace Miriam.Application.Comments;

public interface ICommentRepository : IRepository<CommentEntity>
{
    public Task<IEnumerable<CommentEntity>> GetCommentsByPostId(string postId);
}