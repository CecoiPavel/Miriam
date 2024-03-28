using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Categories;
using Miriam.Domain.Comments;
using Miriam.Domain.Common;
using Miriam.Domain.Posts;
using Miriam.Domain.Tag;
using Miriam.Infrastructure.Authentication;

namespace Miriam.Infrastructure.Persistence;

public class MiriamDbContext(IUnitOfWork unitOfWork, IConfiguration configuration) : DbContext
{
    public DbSet<AuthenticationUser> Users { get; set; }
    public DbSet<PostEntity> Posts { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<PostCategoryEntity> PostCategories { get; set; }
    public DbSet<CommentEntity> Comments { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<PostTagsEntity> PostTags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseLazyLoadingProxies()
            .UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //TODO : Add Entities configs here
        
        base.OnModelCreating(builder);
    }
}