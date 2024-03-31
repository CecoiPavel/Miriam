using Microsoft.EntityFrameworkCore;
using Miriam.Application.Tags;
using Miriam.Domain.Tag;
using Miriam.Infrastructure.Persistence;

namespace Miriam.Infrastructure.Repositories;

public class TagRepository(MiriamDbContext dbContext) : Repository<TagEntity>(dbContext), ITagRepository
{
    public async Task<IEnumerable<TagEntity>> GetTagsByPostId(string postId)
    {
        return await GetChangeTrackingQuery()
            .Where(tag => tag.Posts.Any(post => post.PostId == postId))
            .ToListAsync();
    }
}