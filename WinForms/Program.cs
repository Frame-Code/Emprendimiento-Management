using Controller;
using Datos.Impl;
using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Servicios.Impl;
using Servicios.Interfaces;
using Shared;
using WinForms.Views;
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

        var services = AppHost.Services;
        
        using (var scope = services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<AppContext>();
            db.Database.Migrate();
                                                                    //MainFromView
            var mainForm = scope.ServiceProvider.GetRequiredService<MainEstudianteView>();
            Application.Run(mainForm);
            //var registroEmprendimiento = services.GetRequiredService<RegistroEmprendimientoView>();
            //Application.Run(registroEmprendimiento);
        }
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

                // Repositorios
                services.AddScoped<IEmprendimientoRepository, EmprendimientoRepositoryImpl>();
                services.AddScoped<IRubroEmprendimientoRepository, RubroEmpendimientoRepositoryImpl>();
                services.AddScoped<IVotoRepository, VotoRepositoryImpl>();
                services.AddScoped<IEventoRepository, EventoRepositoryImpl>();
                services.AddScoped<IComentarioRepository, ComentarioRepositoryImpl>();
                services.AddScoped<IRolUsuarioRepository, RolUsuarioRepositoryImpl>();
                services.AddScoped<ICategoriaPremioRepository, CategoriaPremioRepositoryImpl>();
                services.AddScoped<IResultadoEventoRepository, ResultadoEventoRepositoryImpl>();
                services.AddScoped<IAgendaPresentacionRepository, AgendaPresentacionRepositoryImpl>();
                services.AddScoped<IFacultadRepository, FacultadRepositoryImpl>();
                services.AddScoped<IParticipanteRepository, ParticipanteRepositoryImpl>();
                services.AddScoped<ICargoParticipanteRepository, CargoParticipanteRepositoryImpl>();

                // Servicios 
                services.AddScoped<IRegistroEmprendimientoService, RegistroEmprendimientoServiceImpl>();
                services.AddScoped<IParticipanteService, ParticipanteServiceImpl>();

                // Controllers
                services.AddScoped<RegistroEmprendimientoController>();
                services.AddScoped<ParticipanteController>();

                // Formularios
                services.AddScoped<MainFormView>();
                services.AddScoped<EmprendimientosUc>();
                services.AddScoped<RegistroEmprendimientoView>();
                services.AddScoped<DetalleEmprendimientoView>();
                services.AddScoped<ConsultaEmprendimientoView>();
                services.AddScoped<MainEstudianteView>();

            });
    }
}