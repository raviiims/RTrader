using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RTrader.Infrastructure.Persistence.Context;

namespace RTrader.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<RTraderDbContext>(options =>
        {
            options.UseNpgsql(
                configuration.GetConnectionString("Postgres"));
        });

        return services;
    }
}