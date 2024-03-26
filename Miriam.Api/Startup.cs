using Microsoft.AspNetCore.Mvc;
using Miriam.Contracts.Settings;

namespace Miriam.Api;

public class Startup(IConfiguration configuration)
{
    public IConfiguration Configuration { get; } = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        var connectionString = new ConnectionString();
        Configuration.GetSection(StringConstants.ConnectionString).Bind(connectionString);

        services.AddHttpContextAccessor();
        services.AddResponseCaching();
        services.AddApiVersioning();
        
        services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);
    }
}