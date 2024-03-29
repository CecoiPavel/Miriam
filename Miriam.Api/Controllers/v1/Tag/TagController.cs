using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.Base;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v1.Tag;

[AllowAnonymous]
[ApiVersion("1.0")]
public class TagController(IMediator mediator) : BaseController(mediator)
{
    [HttpGet]
    [SwaggerOperation(Summary = "Get all tags")]
    public async Task<IActionResult> GetAllTags()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpGet("postId")]
    [SwaggerOperation(Summary = "Get tags by post Id")]
    public async Task<IActionResult> GetTagsByPostId()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create new tag")]
    public async Task<IActionResult> CreateNewTag()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPut]
    [SwaggerOperation(Summary = "Update tag")]
    public async Task<IActionResult> UpdateTag()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpDelete]
    [SwaggerOperation(Summary = "Delete tag")]
    public async Task<IActionResult> DeleteTag()
    {
        await Task.CompletedTask;
        return Ok();
    }
}