using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.Base;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v1.Comment;

[AllowAnonymous]
[ApiVersion("1.0")]
public class CommentController(IMediator mediator) : BaseController(mediator)
{
    [HttpGet]
    [SwaggerOperation(Summary = "Get all paginated comments")]
    public async Task<IActionResult> GetAllPaginatedComments()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpGet("postId")]
    [SwaggerOperation(Summary = "Get comments by post Id")]
    public async Task<IActionResult> GetCommentsByPostId()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create new comment")]
    public async Task<IActionResult> CreateNewPost()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPut]
    [SwaggerOperation(Summary = "Update comment")]
    public async Task<IActionResult> UpdateComment()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpDelete]
    [SwaggerOperation(Summary = "Delete comment")]
    public async Task<IActionResult> DeleteComment()
    {
        await Task.CompletedTask;
        return Ok();
    }
}