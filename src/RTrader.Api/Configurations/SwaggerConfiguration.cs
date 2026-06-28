using Microsoft.OpenApi;

namespace RTrader.Api.Configurations;

public static class SwaggerConfiguration
{
    public static IServiceCollection AddSwaggerDocumentation(
        this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "RTrader API",
                Version = "v1",
                Description = "API endpoints for the RTrader platform"
            });
        });

        return services;
    }
}