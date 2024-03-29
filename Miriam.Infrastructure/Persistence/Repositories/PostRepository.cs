using Miriam.Application.Posts;
using Miriam.Domain.Posts;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class PostRepository(MiriamDbContext dbContext) : Repository<PostEntity>(dbContext), IPostRepository
{
    public Task<IEnumerable<PostEntity>> GetAllPaginatedPosts()
    {
        throw new NotImplementedException();
    }

    public Task<PostEntity> GetPostByName(string postName)
    {
        throw new NotImplementedException();
    }

    public Task<PostEntity> GetPostByUserId(string userId)
    {
        throw new NotImplementedException();
    }
}