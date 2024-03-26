using Microsoft.Extensions.DependencyInjection;

namespace Miriam.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddRepositoriesConfig();
        return services;
    }

    private static IServiceCollection AddRepositoriesConfig(this IServiceCollection services)
    {
        return services;
    }
}