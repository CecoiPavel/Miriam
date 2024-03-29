using Miriam.Application.Abstractions.Repositories;
using Miriam.Application.Categories;
using Miriam.Application.Comments;
using Miriam.Application.Posts;
using Miriam.Application.Tags;
using Miriam.Application.Users;

namespace Miriam.Infrastructure.Persistence.Repositories;

public sealed class UnitOfWork(MiriamDbContext dbContext, bool disposed) : IUnitOfWork
{
    public IUserRepository UserRepository { get; } = new UserRepository(dbContext);
    public ICommentRepository CommentRepository { get; } = new CommentRepository(dbContext);
    public IPostRepository PostRepository { get; } = new PostRepository(dbContext);
    public ICategoryRepository CategoryRepository { get; } = new CategoryRepository(dbContext);
    public ITagRepository TagRepository { get; } = new TagRepository(dbContext);

    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }

    private async Task DisposeAsync(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                await dbContext.DisposeAsync();
            }
        }

        disposed = true;
    }

    public async void Dispose()
    {
        await DisposeAsync(true);
    }
}