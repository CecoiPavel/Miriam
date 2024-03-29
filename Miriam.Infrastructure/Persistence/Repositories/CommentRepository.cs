using Miriam.Application.Comments;
using Miriam.Domain.Comments;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class CommentRepository(MiriamDbContext dbContext) : Repository<CommentEntity>(dbContext), ICommentRepository
{
    public Task<IEnumerable<CommentEntity>> GetPaginatedCommentsByPostId()
    {
        throw new NotImplementedException();
    }
}