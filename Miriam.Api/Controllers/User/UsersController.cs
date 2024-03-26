using Microsoft.AspNetCore.Mvc;
using Miriam.Api.Controllers.Base;
using Miriam.Contracts.Users;

namespace Miriam.Api.Controllers.User;

public class UsersController : BaseController
{
    public async Task<IActionResult> GetUserById(UserByIdRequest request)
    {
        await Task.CompletedTask;
        return Ok(new UserResponse());
    }
}