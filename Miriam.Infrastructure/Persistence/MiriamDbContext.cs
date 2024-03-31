using Microsoft.EntityFrameworkCore;
using Miriam.Domain.Categories;
using Miriam.Domain.Comments;
using Miriam.Domain.Common;
using Miriam.Domain.Posts;
using Miriam.Domain.Tag;
using Miriam.Infrastructure.Authentication;

namespace Miriam.Infrastructure.Persistence;

public class MiriamDbContext(DbContextOptions<MiriamDbContext> options) : DbContext(options)
{
    
    public DbSet<AuthenticationUser?> Users { get; set; }
    public DbSet<PostEntity?> Posts { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<PostCategoriesEntity> PostCategories { get; set; }
    public DbSet<CommentEntity> Comments { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<PostTagEntity> PostTags { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(DependencyInjection).Assembly);
    }
}