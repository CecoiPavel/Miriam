using Miriam.Application.Comments;
using Miriam.Domain.Comments;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class CommentRepository : Repository<CommentEntity>, ICommentRepository
{
    public Task<IEnumerable<CommentEntity>> GetPaginatedCommentsByPostId()
    {
        throw new NotImplementedException();
    }
}