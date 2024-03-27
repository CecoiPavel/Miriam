using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.Base;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v1.User;

[AllowAnonymous]
[ApiVersion("1.0")]
public class UserController(IMediator mediator) : BaseController(mediator)
{
    [HttpGet("name")]
    [SwaggerOperation(Summary = "Get user by name")]
    public async Task<IActionResult> GetUserByName()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpGet("id")]
    [SwaggerOperation(Summary = "Get user by Id")]
    public async Task<IActionResult> GetUserById()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPost]
    [SwaggerOperation(Summary = "Create new user")]
    public async Task<IActionResult> CreateNewUser()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpPut]
    [SwaggerOperation(Summary = "Update User")]
    public async Task<IActionResult> UpdateUser()
    {
        await Task.CompletedTask;
        return Ok();
    }

    [HttpDelete]
    [SwaggerOperation(Summary = "Delete User")]
    public async Task<IActionResult> DeleteUser()
    {
        await Task.CompletedTask;
        return Ok();
    }
}