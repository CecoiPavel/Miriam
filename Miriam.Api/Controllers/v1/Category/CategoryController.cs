using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.Base;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v1.Category;

[AllowAnonymous]
[Asp.Versioning.ApiVersion("1.0")]
public class CategoryController(IMediator mediator) : BaseController(mediator)
{
    [HttpGet]
    [SwaggerOperation(Summary = "Get all categories")]
    public async Task<IActionResult> GetAllCategories()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpGet("postId")]
    [SwaggerOperation(Summary = "Get category by postId")]
    public async Task<IActionResult> GetCategoryByPostId()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create new category")]
    public async Task<IActionResult> CreateNewCategory()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPut]
    [SwaggerOperation(Summary = "Update category")]
    public async Task<IActionResult> UpdateCategory()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpDelete]
    [SwaggerOperation(Summary = "Delete category")]
    public async Task<IActionResult> DeleteCategory()
    {
        await Task.CompletedTask;
        return Ok();
    }
}