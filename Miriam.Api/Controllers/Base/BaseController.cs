using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Miriam.Api.Controllers.v1.Base;

[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public abstract class BaseController(IMediator mediator) : ControllerBase
{
    
}