using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Posts;

namespace Miriam.Application.Posts;

public interface IPostRepository : IRepository<PostEntity>
{
   public Task<IEnumerable<PostEntity>> GetAllPaginatedPosts();
   public Task<PostEntity> GetPostByName(string postName);
   public Task<PostEntity> GetPostByUserId(string userId);
}