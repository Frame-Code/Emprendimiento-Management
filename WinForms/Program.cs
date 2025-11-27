using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AppContext = Datos.AppContext;

namespace WinForms;

internal static class Program
{
    private static IHost? AppHost { get; set; }
    
    [STAThread]
    static void Main()
    {
        AppHost = CreateHostBuilder().Build();
        if (AppHost == null)
            throw new Exception("No se pudo iniciar el Host global de DI");
        
        ApplicationConfiguration.Initialize();

        using var scope = AppHost.Services.CreateScope();
        
        var db = scope.ServiceProvider.GetRequiredService<AppContext>();
        db.Database.Migrate();
        
        var mainForm = scope.ServiceProvider.GetRequiredService<MainForm>();
        //Application.Run(mainForm);
        Console.WriteLine("App started");
    }

    private static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.Sources.Clear();
                config .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                IConfiguration configuration = context.Configuration;
                
                var connectionString = configuration.GetConnectionString("AppDb");

                services.AddDbContext<AppContext>(options =>
                    options.UseSqlServer(connectionString));

                // Registrar servicios al inyector
                services.AddScoped<MainForm>();
            });
    }
}