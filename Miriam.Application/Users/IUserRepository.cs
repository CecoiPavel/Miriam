using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Common;
using Miriam.Domain.Users;

namespace Miriam.Application.Users;

public interface IUserRepository : IRepository<UserEntity>
{
    Task<List<IUser>> GetUser();
    public Task<UserEntity> GetUserByName(string userName);
}