using MediatR;
using Miriam.Domain.Posts;

namespace Miriam.Application.Posts.Queries.GetAllPosts;

public class GetAllPostsQueryHandler(IPostRepository postRepository)
    : IRequestHandler<GetAllPostsQuery, List<PostEntity>>
{
    public Task<List<PostEntity>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
    {
        return postRepository.GetAllPosts();
    }
}