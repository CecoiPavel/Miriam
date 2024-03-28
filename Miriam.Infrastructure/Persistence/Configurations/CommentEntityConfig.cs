using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Miriam.Domain.Comments;

namespace Miriam.Infrastructure.Persistence.Configurations;

public class CommentEntityConfig : IEntityTypeConfiguration<CommentEntity>
{
    public void Configure(EntityTypeBuilder<CommentEntity> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.ParentCommentId);

        builder.HasOne(c => c.ParentComment)
            .WithMany()
            .HasForeignKey(c => c.ParentCommentId);

        builder.HasOne(c => c.Post)
            .WithMany(p => p.Comments);
    }
}