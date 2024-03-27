using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.v1.Base;
using Miriam.Contracts.Users;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v2.User;

[AllowAnonymous]
[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
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