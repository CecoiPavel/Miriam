using Miriam.Application.Categories;
using Miriam.Domain.Categories;

namespace Miriam.Infrastructure.Persistence.Repositories;

public class CategoryRepository(MiriamDbContext dbContext) : Repository<CategoryEntity>(dbContext), ICategoryRepository
{
    public Task<IEnumerable<CategoryEntity>> GetAllCategoriesByPostId(string postId)
    {
        throw new NotImplementedException();
    }
}