using MediatR;
using Miriam.Application.Authentication.Common;

namespace Miriam.Application.Authentication.Queries.Login;

public record LoginQuery(string UserName, string Password) : IRequest<AuthenticationDto>;
