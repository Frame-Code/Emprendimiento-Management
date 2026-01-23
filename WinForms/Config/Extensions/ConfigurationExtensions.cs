using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace WinForms.Config.Extensions;

public static class ConfigurationExtensions
{
    public static IHostBuilder AddConfig(this IHostBuilder builder)
    {
        return builder.ConfigureAppConfiguration((context, config) =>
        {
            config.Sources.Clear();
            config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        });
    }
}