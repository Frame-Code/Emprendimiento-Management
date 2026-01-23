using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AppContext = Datos.AppContext;

namespace WinForms.Config.Extensions;

public static class DbContextExtensions
{
    public static IHostBuilder AddDbContext(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureServices((context, services) =>
        {
            var configuration = context.Configuration;
            var connectionString = configuration.GetConnectionString("AppDb");
            services.AddDbContext<AppContext>(options => options.UseSqlServer(connectionString));
        });
    }
}