using Miriam.Domain.Base;

namespace Miriam.Application.Abstractions.Repositories;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveChangesAsync();
    IRepository<T> Repository<T>() where T : Entity;
}