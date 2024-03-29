using Miriam.Domain.Base;

namespace Miriam.Application.Abstractions.Repositories;

public interface IRepository<TEntity> : IDisposable where TEntity : Entity
{
    public Task<IEnumerable<TEntity>> GetAll();
    public Task<TEntity?> GetById(int entityId);
    public Task<TEntity> Create(TEntity entity);
    public Task<TEntity> Update(TEntity entity);
    public Task Delete(int entityId);
}