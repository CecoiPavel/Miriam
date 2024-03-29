using Miriam.Application.Categories;
using Miriam.Application.Comments;
using Miriam.Application.Posts;
using Miriam.Application.Tags;
using Miriam.Application.Users;

namespace Miriam.Application.Abstractions.Repositories;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync();
    IUserRepository UserRepository { get; }
    ICommentRepository CommentRepository { get; }
    IPostRepository PostRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    ITagRepository TagRepository{ get; }
}