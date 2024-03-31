using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Tag;

namespace Miriam.Application.HashTags;

public interface IHashTagRepository : IRepository<TagEntity>
{
    public Task<IEnumerable<TagEntity>> GetTagsByPostId();
}