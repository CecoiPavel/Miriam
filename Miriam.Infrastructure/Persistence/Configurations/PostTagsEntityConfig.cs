using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Miriam.Domain.Common;

namespace Miriam.Infrastructure.Persistence.Configurations;

public class PostTagsEntityConfig : IEntityTypeConfiguration<PostTagsEntity>
{
    public void Configure(EntityTypeBuilder<PostTagsEntity> builder)
    {
        builder.HasKey(pt => pt.Id);

        builder.Property(pt => pt.PostId);

        builder.Property(pt => pt.TagId);

        builder.HasOne(pt => pt.Post)
            .WithMany(p => p.Tags)
            .HasForeignKey(pt => pt.PostId);

        builder.HasOne(pt => pt.Tag)
            .WithMany(t => t.Posts)
            .HasForeignKey(pt => pt.TagId);
    }
}