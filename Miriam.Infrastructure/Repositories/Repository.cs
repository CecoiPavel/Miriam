using Microsoft.EntityFrameworkCore;
using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Base;
using Miriam.Infrastructure.Persistence;

namespace Miriam.Infrastructure.Repositories;

public class Repository<TEntity>(MiriamDbContext dbContext) : IRepository<TEntity> where TEntity : Entity
{
    protected DbSet<TEntity> Table { get; }
    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await dbContext.Set<TEntity>().ToListAsync();
    }

    public IQueryable<TEntity> GetReadOnlyQuery()
    {
        return Table.AsNoTracking();
    }

    public IQueryable<TEntity> GetChangeTrackingQuery()
    {
        return Table.AsTracking();
    }

    public async Task<TEntity?> GetById(int entityId)
    {
        return await dbContext.Set<TEntity>().FindAsync(entityId);
    }

    public async Task<TEntity> Create(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        await dbContext.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        dbContext.Entry(entity).State = EntityState.Modified;
        return entity;
    }

    public async Task Delete(int entityId)
    {
        var entity = await dbContext.Set<TEntity>().FindAsync(entityId);
        if (entity != null)
        {
            dbContext.Set<TEntity>().Remove(entity);
        }
    }

    public void Dispose()
    {
        dbContext.Dispose();
    }
}