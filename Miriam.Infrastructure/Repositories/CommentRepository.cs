using Microsoft.EntityFrameworkCore;
using Miriam.Application.Comments;
using Miriam.Domain.Comments;
using Miriam.Infrastructure.Persistence;

namespace Miriam.Infrastructure.Repositories;

public class CommentRepository(MiriamDbContext dbContext) : Repository<CommentEntity>(dbContext), ICommentRepository
{
    public async Task<IEnumerable<CommentEntity>> GetCommentsByPostId(string postId)
    {
        return await GetChangeTrackingQuery()
            .Where(c => c.PostId == postId)
            .OrderByDescending(c => c.CreationTime)
            .ToListAsync();
    }
}