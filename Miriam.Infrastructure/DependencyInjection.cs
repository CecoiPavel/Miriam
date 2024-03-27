using Microsoft.Extensions.DependencyInjection;

namespace Miriam.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddRepositoriesConfig();
        return services;
    }

    private static void AddRepositoriesConfig(this IServiceCollection services)
    {
    }
}