using RTrader.Api.Configurations;
using RTrader.Api.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) =>
{
    lc.ReadFrom.Configuration(ctx.Configuration)
      .WriteTo.Console()
      .WriteTo.File(
            "Logs/log-.txt",
            rollingInterval:
            RollingInterval.Day);
});

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddSwaggerDocumentation();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.ConfigurePipeline();

app.Run();