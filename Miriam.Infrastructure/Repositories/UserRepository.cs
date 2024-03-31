using Microsoft.EntityFrameworkCore;
using Miriam.Application.Users;
using Miriam.Domain.Common;
using Miriam.Domain.Users;
using Miriam.Infrastructure.Persistence;

namespace Miriam.Infrastructure.Repositories;

public class UserRepository(MiriamDbContext context) : Repository<UserEntity>(context), IUserRepository
{
    public Task<List<IUser>> GetUser()
    {
        var result = context.Users.ToList();
        return Task.FromResult(result.Cast<IUser>().ToList());
    }

    public async Task<IUser?> GetUserByName(string userName)
    {
        return await context.Users
            .FirstOrDefaultAsync(post => post.UserName == userName);
    }
}