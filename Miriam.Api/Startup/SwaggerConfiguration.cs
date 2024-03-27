using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Miriam.Api.Startup;

public class SwaggerConfiguration(IApiVersionDescriptionProvider provider) 
    : IConfigureOptions<SwaggerGenOptions>
{
    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in provider.ApiVersionDescriptions)
            options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
    }

    private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
    {
        var info = new OpenApiInfo
        {
            Title = "Miriam API",
            Version = description.ApiVersion.ToString(),
            Description = "Developed by BigMac"
        };

        if (description.IsDeprecated) info.Description += " This API version has been deprecated.";

        return info;
    }
}