using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Miriam.Domain.Common;

namespace Miriam.Infrastructure.Persistence.Configurations;

public class PostCategoriesEntityConfig : IEntityTypeConfiguration<PostCategoriesEntity>
{
    public void Configure(EntityTypeBuilder<PostCategoriesEntity> builder)
    {
        builder.HasKey(pc => pc.Id);

        builder.Property(pc => pc.PostId);

        builder.Property(pc => pc.CategoryId);

        builder.HasOne(pc => pc.Post)
            .WithMany(p => p.Categories)
            .HasForeignKey(pc => pc.PostId);

        builder.HasOne(pc => pc.Category)
            .WithMany(c => c.Posts)
            .HasForeignKey(pc => pc.CategoryId);
    }
}