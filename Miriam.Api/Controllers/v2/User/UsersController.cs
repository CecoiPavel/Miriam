using MediatR;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.Base;
using Miriam.Contracts.Users;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v2.User;

[ApiVersion("2.0")]
public class UsersController(IMediator mediator) : BaseController(mediator)
{
    [SwaggerOperation(Summary = "Get user by id")]
    [HttpPost("user")]
    public async Task<IActionResult> GetUserById(UserByIdRequest request)
    {
        await Task.CompletedTask;
        return Ok(new UserResponse());
    }
}