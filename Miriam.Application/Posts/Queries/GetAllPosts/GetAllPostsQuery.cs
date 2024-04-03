using MediatR;
using Miriam.Domain.Posts;

namespace Miriam.Application.Posts.Queries.GetAllPosts;

public record GetAllPostsQuery : IRequest<List<PostEntity>>;