using System.Text;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Miriam.Api;
using Miriam.Api.Startup;
using Miriam.Application;
using Miriam.Infrastructure;
using Swashbuckle.AspNetCore.SwaggerGen;
using DependencyInjection = Miriam.Application.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
{
    //Configuration
    var configuration = builder.Configuration;

    //Add services to the container
    builder.Services.AddMediatR(config =>
        config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

    builder.Services.AddControllers();

    builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerConfiguration>();
    //Swagger
    builder.Services.AddSwaggerGen(genOptions =>
    {
        genOptions.SupportNonNullableReferenceTypes();
        genOptions.EnableAnnotations();

        genOptions.CustomSchemaIds(x =>
        {
            var projectName = x.Assembly.FullName?.Split(",").FirstOrDefault();
            return $"{projectName}_{x.GetHashCode()}.{x.Name}";
        });

        genOptions.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = "Enter JWT Bearer token to access Miriam",
            Name = "JWT Authentication",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.Http,
            Scheme = "Bearer"
        });
        genOptions.ResolveConflictingActions(apiDescriptions => apiDescriptions.FirstOrDefault());
        genOptions.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    },
                    Scheme = "oauth2",
                    Name = "Bearer",
                    In = ParameterLocation.Header
                },
                new List<string>()
            }
        });
    });

    //API Versioning
    builder.Services.AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);
        options.ReportApiVersions = true;
        options.AssumeDefaultVersionWhenUnspecified = true;
        options.ApiVersionReader = ApiVersionReader.Combine(
            new UrlSegmentApiVersionReader(),
            new HeaderApiVersionReader("api-version"));
    })
        
        .EnableApiVersionBinding()
        .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });
}

//App builder
var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseRouting();

    app.UseAuthorization();
    app.UseAuthentication();

    app.MapControllers();

    //Run
    app.Run();
}