using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Miriam.Application.Categories;
using Miriam.Application.Comments;
using Miriam.Application.Posts;
using Miriam.Application.Tags;
using Miriam.Application.Users;
using Miriam.Infrastructure.Persistence;
using Miriam.Infrastructure.Persistence.Repositories;

namespace Miriam.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        services.AddDbContextConfig(configuration);
        services.AddRepositoriesConfig();
        return services;
    }

    private static void AddRepositoriesConfig(this IServiceCollection services)
    {
        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<ITagRepository, TagRepository>();
        services.AddTransient<ICommentRepository, CommentRepository>();
        services.AddTransient<IPostRepository, PostRepository>();
    }

    private static void AddDbContextConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MiriamDbContext>(options =>
        {
            options.UseLazyLoadingProxies(); // Enable lazy loading
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}