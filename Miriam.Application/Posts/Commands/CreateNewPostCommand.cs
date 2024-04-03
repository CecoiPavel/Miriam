using MediatR;
using Miriam.Application.Posts.Common;
using Miriam.Domain.Posts;

namespace Miriam.Application.Posts.Commands;

public record CreateNewPostCommand(PostDto dto) : IRequest<PostEntity>
{
    
}