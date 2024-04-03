using MediatR;
using Miriam.Application.Posts.Common;
using Miriam.Domain.Posts;

namespace Miriam.Application.Posts.Commands;

public class CreateNewPostCommandHandler(IPostRepository postRepository)
    : IRequestHandler<CreateNewPostCommand, PostEntity>
{
    public Task<PostEntity> Handle(CreateNewPostCommand request, CancellationToken cancellationToken)
    {
        return postRepository.Create(PostDto.ToEntity(request.dto));
    }
}