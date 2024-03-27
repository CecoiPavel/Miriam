using Miriam.Domain.Common;

namespace Miriam.Application.Users;

public interface IUserRepository
{
    Task<List<IUser>> GetUser();
}