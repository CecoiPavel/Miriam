using Microsoft.EntityFrameworkCore;
using Miriam.Application.Tags;
using Miriam.Domain.Tag;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class TagRepository(DbContext dbContext) : Repository<TagEntity>(dbContext), ITagRepository
{
    public Task<IEnumerable<TagEntity>> GetTagsByPostId(string postId)
    {
        throw new NotImplementedException();
    }
}