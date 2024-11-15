using Connectr.TechTests.Backend.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StarwarsDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services
    .AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.WriteIndented = true);

var app = builder.Build();

CreateDbIfNotExists(app.Services);

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.MapGet("/", async context => await context.Response.WriteAsync(File.ReadAllText("../README.md")));

app.MapControllers();

app.Run();

static void CreateDbIfNotExists(IServiceProvider provider)
{
    using var scope = provider.CreateScope();
    try
    {
        var context = scope.ServiceProvider.GetRequiredService<StarwarsDbContext>();
        StarwarsDbInitializer.Initialize(context);
    }
    catch (Exception ex)
    {
        var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}
