using Microsoft.Extensions.Hosting;
using WinForms.Config.Extensions;

namespace WinForms.Config;

public static class DependencyInjection
{
    public static IHostBuilder InitializeServices(this IHostBuilder builder)
    {
        return builder
            .AddConfig()
            .AddDbContext()
            .AddServices();
    }
}