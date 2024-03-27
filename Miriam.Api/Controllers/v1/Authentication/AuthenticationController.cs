using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.Base;
using Miriam.Application.Authentication.Command;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v1.Authentication;

[ApiVersion("1.0")]
public class AuthenticationController(IMediator mediator) : BaseController(mediator)
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("authentication")]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "LogIn")]
    public async Task<IActionResult> LogIn()
    {
        var token = await _mediator.Send(new AuthenticationCommand());
        return Ok(token);
    }
}