using Miriam.Application.Users;
using Miriam.Domain.Common;
using Miriam.Domain.Users;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class UserRepository(MiriamDbContext context) : Repository<UserEntity>(context), IUserRepository
{
    public Task<List<IUser>> GetUser()
    {
        var result = context.Users.ToList();
        return Task.FromResult(result.Cast<IUser>().ToList());
    }

    public Task<UserEntity> GetUserByName(string userName)
    {
        throw new NotImplementedException();
    }
}