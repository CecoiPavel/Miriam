using Miriam.Domain.Base;
using Miriam.Domain.Comments;
using Miriam.Domain.Common;
using Miriam.Domain.Users;

namespace Miriam.Domain.Posts;

public class PostEntity : EntityFullAudited
{
    public string Title { get; set; }
    public string Content { get; set; }
    public virtual UserEntity UserEntity { get; set; }
    public virtual ICollection<PostCategoryEntity> Categories { get; set; }
    public virtual ICollection<CommentEntity> Comments { get; set; }
    public virtual ICollection<PostTagsEntity> Tags { get; set; }

    public static PostEntity Create(
        string title,
        string content,
        UserEntity user,
        ICollection<PostCategoryEntity> categories,
        ICollection<CommentEntity> comments,
        ICollection<PostTagsEntity> tags)
    {
        return new PostEntity
        {
            Title = title,
            Content = content,
            UserEntity = user,
            //Forget not about CreationTime
            CreatedByUserId = user.Id,
            Categories = categories,
            Comments = comments,
            Tags = tags
        };
    }

    public PostEntity Update(
        string title,
        string content,
        DateTimeOffset modificationTime,
        UserEntity user,
        ICollection<PostCategoryEntity> categories,
        ICollection<CommentEntity> comments,
        ICollection<PostTagsEntity> tags)
    {
        Title = title;
        Content = content;
        LastModificationTime = modificationTime;
        LastModifiedByUserId = user.Id;
        UserEntity = user;
        Categories = categories;
        Comments = comments;
        Tags = tags;

        return this;
    }
}