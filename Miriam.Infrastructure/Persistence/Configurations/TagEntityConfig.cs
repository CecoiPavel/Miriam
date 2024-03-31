using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Miriam.Domain.Tag;

namespace Miriam.Infrastructure.Persistence.Configurations;

public class TagEntityConfig : IEntityTypeConfiguration<TagEntity>
{
    public void Configure(EntityTypeBuilder<TagEntity> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(t => t.Description);

        builder.HasMany(t => t.Posts)
            .WithOne(pt => pt.Tag)
            .HasForeignKey(pt => pt.TagId);
    }
}