using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Miriam.Domain.Posts;

namespace Miriam.Infrastructure.Persistence.Configurations;

public class PostEntityConfig : IEntityTypeConfiguration<PostEntity>
{
    public void Configure(EntityTypeBuilder<PostEntity> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(p => p.Content)
            .IsRequired();

        builder.HasOne(p => p.UserEntity)
            .WithMany(p => p.Posts)
            .HasForeignKey(p => p.UserId);

        builder.HasMany(p => p.Categories)
            .WithOne(pc => pc.Post)
            .HasForeignKey(pc => pc.PostId);

        builder.HasMany(p => p.Comments)
            .WithOne(c => c.Post)
            .HasForeignKey(c => c.PostId);

        builder.HasMany(p => p.Tags)
            .WithOne(pt => pt.Post)
            .HasForeignKey(pt => pt.PostId);
    }
}