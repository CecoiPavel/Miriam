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

        builder.HasOne<CommentEntity>(c => c.ParentComment)
            .WithOne()
            .HasForeignKey<CommentEntity>(c => c.ParentCommentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(c => c.Post)
            .WithMany(p => p.Comments)
            .OnDelete(DeleteBehavior.NoAction);
    }
}