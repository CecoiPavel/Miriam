using Microsoft.EntityFrameworkCore;
using Miriam.Application.Posts;
using Miriam.Domain.Posts;
using Miriam.Infrastructure.Persistence;

namespace Miriam.Infrastructure.Repositories;

public class PostRepository(MiriamDbContext dbContext) : Repository<PostEntity>(dbContext), IPostRepository
{
    public async Task<List<PostEntity?>> GetAllPosts()
    {
        return await dbContext.Posts
            .OrderByDescending(c => c.CreationTime)
            .ToListAsync();
    }

    public async Task<PostEntity?> GetPostByTitle(string postTitle)
    {
        return await GetChangeTrackingQuery()
            .FirstOrDefaultAsync(post => post.Title == postTitle);
    }
}