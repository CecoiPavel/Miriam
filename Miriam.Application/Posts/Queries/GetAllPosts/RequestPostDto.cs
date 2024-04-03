using Miriam.Application.Posts.Common;
using Miriam.Domain.Posts;

namespace Miriam.Application.Posts.Queries.GetAllPosts;

public class RequestPostDto
{
    public IEnumerable<PostDto>? Posts { get; set; }

    public static RequestPostDto FromEntity(IEnumerable<PostEntity> postEntities)
    {
        var posts = postEntities.Select(post => new PostDto()
        {
            Title = post.Title,
            UserName = post.UserEntity.UserName
        });
        return new RequestPostDto()
        {
            Posts = posts
        };
    }
}