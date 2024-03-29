using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Miriam.Application.Abstractions.Repositories;
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
        services.AddRepositoriesConfig();
        services.AddDbContextConfig(configuration);
        return services;
    }

    private static void AddRepositoriesConfig(this IServiceCollection services)
    {
        services.AddTransient<IUnitOfWork>(provider =>
        {
            var dbContext = provider.GetRequiredService<MiriamDbContext>();

            var disposed = false;

            return new UnitOfWork(dbContext, disposed);
        });

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<ITagRepository, TagRepository>();
        services.AddTransient<ICommentRepository, CommentRepository>();
        services.AddTransient<IPostRepository, PostRepository>();
    }

    private static void AddDbContextConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextPool<MiriamDbContext>(options =>
        {
            options.UseLazyLoadingProxies(); // Enable lazy loading
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}