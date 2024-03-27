using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.v1.Base;
using Miriam.Application.Authentication.Command;
using Swashbuckle.AspNetCore.Annotations;

namespace Miriam.Api.Controllers.v1.Authentication;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class LogInController(IMediator mediator) : BaseController(mediator)
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("authentication")]
    [AllowAnonymous]
    [SwaggerOperation(Summary = "Authentication")]
    public async Task<IActionResult> Authentication()
    {
        var token = await _mediator.Send(new AuthenticationCommand());
        return Ok(token);
    }
}