using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.Base;
using Miriam.Application.Posts.Commands;
using Miriam.Application.Posts.Common;
using Miriam.Application.Posts.Queries.GetAllPosts;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v1.Post;

[AllowAnonymous]
[ApiVersion("1.0")]
public class PostController(IMediator mediator) : BaseController(mediator)
{
    [HttpGet]
    [SwaggerOperation(Summary = "Get all paginated posts")]
    public async Task<RequestPostDto> GetAllPaginatedPosts()
    {
        var result = await mediator.Send(new GetAllPostsQuery());
        return RequestPostDto.FromEntity(result);
    }

    [HttpGet("name")]
    [SwaggerOperation(Summary = "Get post by name")]
    public async Task<IActionResult> GetPostByName()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpGet("id")]
    [SwaggerOperation(Summary = "Get post by Id")]
    public async Task<IActionResult> GetPostById()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpGet("userid")]
    [SwaggerOperation(Summary = "Get post by user Id")]
    public async Task<IActionResult> GetPostByUserId()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create new post")]
    public async Task<PostDto> CreateNewPost([FromBody] PostDto request)
    {
        var result = await mediator.Send(new CreateNewPostCommand(request));
        return PostDto.ToDto(result);
    }

    [HttpPut]
    [SwaggerOperation(Summary = "Update post")]
    public async Task<IActionResult> UpdatePost()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpDelete]
    [SwaggerOperation(Summary = "Delete Post")]
    public async Task<IActionResult> DeletePost()
    {
        await Task.CompletedTask;
        return Ok();
    }
}