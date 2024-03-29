using Microsoft.EntityFrameworkCore;
using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Base;

namespace Miriam.Infrastructure.Persistence.Repositories;

public sealed class UnitOfWork(DbContext dbContext, bool disposed) : IUnitOfWork
{
    public async Task<int> SaveChangesAsync()
    {
        return await dbContext.SaveChangesAsync();
    }

    public IRepository<T> Repository<T>() where T : Entity
    {
        return new Repository<T>(dbContext);
    }

    private async Task DisposeAsync(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                await dbContext.DisposeAsync();
            }
        }

        disposed = true;
    }

    public async void Dispose()
    {
        await DisposeAsync(true);
    }
}