using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinForms.Config;
using WinForms.Config.Extensions;
using WinForms.Views;
using AppContext = Datos.AppContext;

namespace WinForms;
internal static class Program
{
    private static IHost? AppHost { get; set; }
    
    [STAThread]
    static async Task Main()
    {
        AppHost = Host.CreateDefaultBuilder()
            .InitializeServices()
            .Build();
        
        if (AppHost == null)
            throw new Exception("No se pudo iniciar el Host global de DI");
        
        ApplicationConfiguration.Initialize();

        var services = AppHost.Services;
        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
        using var scope = services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppContext>();
        await db.Database.MigrateAsync();
        await db.ExecuteSqlScriptAsync("Scripts\\init.sql");
        var view = scope.ServiceProvider.GetRequiredService<LogIn>();
        Application.Run(view);
    }
}