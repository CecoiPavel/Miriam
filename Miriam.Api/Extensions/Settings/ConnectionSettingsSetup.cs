using Microsoft.Extensions.Options;
using Miriam.Contracts.Settings;

namespace Miriam.Api.Extensions.Settings;

public class ConnectionStringsSetup(IConfiguration configuration) : IConfigureOptions<ConnectionString>
{
    private const string SectionName = "Connections:DefaultConnection";

    public void Configure(ConnectionString options)
    {
        options.String = configuration.GetConnectionString("DefaultConnection");
    }
}
