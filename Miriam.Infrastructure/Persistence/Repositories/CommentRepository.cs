using Microsoft.EntityFrameworkCore;
using Miriam.Application.Comments;
using Miriam.Domain.Comments;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class CommentRepository(DbContext dbContext) : Repository<CommentEntity>(dbContext), ICommentRepository
{
    public Task<IEnumerable<CommentEntity>> GetPaginatedCommentsByPostId()
    {
        throw new NotImplementedException();
    }
}