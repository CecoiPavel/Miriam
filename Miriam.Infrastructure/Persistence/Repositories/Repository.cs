using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Base;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public IUnitOfWork UnitOfWork { get; }
    public Task<IEnumerable<TEntity>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetById(int entityId)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> Create(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int entityId)
    {
        throw new NotImplementedException();
    }
}