using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Posts;

namespace Miriam.Application.Posts;

public interface IPostRepository : IRepository<PostEntity>
{
   public Task<List<PostEntity?>> GetAllPosts();
   public Task<PostEntity?> GetPostByTitle(string postTitle);
}