using Miriam.Application.Users;
using Miriam.Domain.Common;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public async Task<List<IUser>> GetUser()
    {
        await Task.CompletedTask;
        var result = context.Users.ToList();
        return result.Cast<IUser>().ToList();
    }
}