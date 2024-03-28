using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Tag;

namespace Miriam.Application.Tags;

public interface ITagRepository : IRepository<TagEntity>
{
    public Task<IEnumerable<TagEntity>> GetTagsByPostId(string postId);
}