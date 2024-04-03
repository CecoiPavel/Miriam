using Miriam.Domain.Categories;
using Miriam.Domain.Posts;
using Miriam.Domain.Users;

namespace Miriam.Application.Posts.Common;

public class PostDto
{
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? UserName { get; set; }
    public IEnumerable<PostCategoriesDto>? Categories { get; set; }
    public IEnumerable<PostTagsDto>? Tags { get; set; }

    public static PostEntity ToEntity(PostDto dto)
    {
        var post = new PostEntity
        {
            Title = dto.Title,
            LastModificationTime = DateTimeOffset.Now,
            CreationTime = DateTimeOffset.Now,
            Content = dto.Content,
            
            
        };

        return new PostEntity
        {
            UserEntity = new UserEntity
            {
                UserName = dto.UserName
            }
        };
    }

    public static PostDto ToDto(PostEntity entity)
    {
        return new PostDto
        {
            Title = entity.Title,
            UserName = entity.UserEntity.UserName,
            Categories = entity.Categories.Select(c => new PostCategoriesDto
            {
                Id = c.Category.Id,
                Title = c.Category.Title
            }),
            Tags = entity.Tags.Select(t => new PostTagsDto
            {
                Id = t.Tag.Id,
                Title = t.Tag.Title
            })
        };
    }

    public class PostCategoriesDto
    {
        public string Id { get; set; }
        public string? Title { get; set; }

        public static PostCategoriesDto? From(CategoryEntity? entity)
        {
            if (entity is null) return null;

            return new PostCategoriesDto
            {
                Id = entity.Id,
                Title = entity.Title
            };
        }
    }

    public class PostTagsDto
    {
        public string Id { get; set; }
        public string? Title { get; set; }

        public static PostTagsDto? From(PostEntity? entity)
        {
            if (entity is null) return null;

            return new PostTagsDto
            {
                Id = entity.Id,
                Title = entity.Title
            };
        }
    }
}