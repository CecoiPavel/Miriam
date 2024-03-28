using Miriam.Application.Users;
using Miriam.Domain.Common;
using Miriam.Domain.Users;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class UserRepository(MiriamDbContext context) : Repository<UserEntity>, IUserRepository
{
    public async Task<List<IUser>> GetUser()
    {
        await Task.CompletedTask;
        var result = context.Users.ToList();
        return result.Cast<IUser>().ToList();
    }

    public Task<UserEntity> GetUserByName(string userName)
    {
        throw new NotImplementedException();
    }
}