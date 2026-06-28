using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace RTrader.Infrastructure.Persistence.Context;

public class RTraderDbContextFactory : IDesignTimeDbContextFactory<RTraderDbContext>
{
    public RTraderDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("../RTrader.Api/appsettings.json")
            .Build();

        var optionsBuilder =
            new DbContextOptionsBuilder<RTraderDbContext>();

        optionsBuilder.UseNpgsql(
            configuration.GetConnectionString("Postgres"));

        return new RTraderDbContext(optionsBuilder.Options);
    }
}