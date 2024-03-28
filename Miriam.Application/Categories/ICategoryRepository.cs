using Miriam.Application.Abstractions.Repositories;
using Miriam.Domain.Categories;

namespace Miriam.Application.Categories;

public interface ICategoryRepository : IRepository<CategoryEntity>
{
    public Task<IEnumerable<CategoryEntity>> GetAllCategoriesByPostId(string postId);
}