using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddOcelot("OcelotConfigs", builder.Environment);

// Add services to the container.

builder.Services.AddOcelot();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.UseOcelot();

app.Run();