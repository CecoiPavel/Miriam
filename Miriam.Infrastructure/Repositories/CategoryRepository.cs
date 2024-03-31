using Microsoft.EntityFrameworkCore;
using Miriam.Application.Categories;
using Miriam.Domain.Categories;
using Miriam.Infrastructure.Persistence;

namespace Miriam.Infrastructure.Repositories;

public class CategoryRepository(MiriamDbContext dbContext) : Repository<CategoryEntity>(dbContext), ICategoryRepository
{
    public async Task<IEnumerable<CategoryEntity>> GetAllCategoriesByPostId(string postId)
    {
        return await GetChangeTrackingQuery()
            .Where(c => c.Posts.Any(pc => pc.PostId == postId))
            .ToListAsync();
    }
}