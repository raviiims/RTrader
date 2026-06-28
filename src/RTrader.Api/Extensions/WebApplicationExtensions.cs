using RTrader.Api.Middlewares;

namespace RTrader.Api.Extensions;

public static class WebApplicationExtensions
{
    public static WebApplication ConfigurePipeline(
        this WebApplication app)
    {
        app.UseMiddleware<GlobalExceptionMiddleware>();

        app.UseSwagger();

        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.MapHealthChecks("/health");

        return app;
    }
}