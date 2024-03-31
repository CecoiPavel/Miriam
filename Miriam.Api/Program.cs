using Miriam.Api;
using Miriam.Application;
using Miriam.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    var configuration = builder.Configuration;

    builder.Services
        .AddApplication()
        .AddInfrastructure(configuration)
        .AddPresentation(configuration);
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