using Controller;
using Datos.Impl;
using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Servicios.Impl;
using Servicios.Interfaces;
using Servicios.Reports;
using Shared;
using Shared.ViewRol;
using WinForms.Views;
using WinForms.Views.UserControls;
using WinForms.Views.Util;
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
        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
        
        using (var scope = services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<AppContext>();
            //db.Database.Migrate();

            var view = scope.ServiceProvider.GetRequiredService<LogIn>();
            Application.Run(view);
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
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
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
                services.AddScoped<ICalendarioService, CalendarioServiceImpl>();
                services.AddScoped<ICronogramaRepository, CronogramaRepositoryImpl>();
                services.AddScoped<IPresentacionRepository, PresentacionRepositoryImpl>();
                services.AddScoped<IUsuarioRepository, UsuarioRepositoryImpl>();
                services.AddScoped<IRolUsuarioRepository, RolUsuarioRepositoryImpl>();
                services.AddScoped<IMenuOpcionesRepository, MenuOpcionesRepository>();
                services.AddScoped<IFotoRepository, FotoRepositoryImpl>();
                services.AddScoped<IPremiacionRepository, PremiacionRepositoryImpl>();

                // Servicios 
                services.AddScoped<IEmprendimientoService, EmprendimientoServiceImpl>();
                services.AddScoped<IParticipanteService, ParticipanteServiceImpl>();
                services.AddScoped<IRegistroParticipanteService, RegistroParticipanteService>();
                services.AddScoped<IAgendaService, AgendaServiceImpl>();
                services.AddScoped<ILogInService, LogInServiceImpl>();
                services.AddScoped<IRolUsuarioService, RolUsuarioServiceImpl>();
                services.AddScoped<ISignUpService, SignUpServiceImpl>();
                services.AddScoped<IMenuOpcionesService, MenuOpcionesServiceImpl>();
                services.AddScoped<IFacultadService, FacultadServiceImpl>();
                services.AddScoped<IRubroEmprendimientoService, RubroEmprendimientoService>();
                services.AddScoped<IFileService, FileServiceImpl>();
                services.AddScoped<IEventoService, EventoServiceImpl>();
                services.AddScoped<IPremiacionService, PremiacionServiceImpl>();
                services.AddScoped<IPdfReportGenerator, PdfReportGeneratorImpl>();
                services.AddScoped<IReport, PremiacionReportPdf>();

                // Controllers 
                services.AddScoped<EmprendimientoController>();
                services.AddScoped<ParticipanteController>();
                services.AddScoped<RegistroParticipanteController>();
                services.AddScoped<CalendarioController>();
                services.AddScoped<AgendaController>();
                services.AddScoped<AuthController>();
                services.AddScoped<MenuOpcionesController>();
                services.AddScoped<FacultadController>();
                services.AddScoped<RubroEmprendimientoController>();
                services.AddScoped<FileController>();
                services.AddScoped<EventoController>();
                services.AddScoped<PremiacionController>();
                services.AddScoped<DetallePremiacionView>();


                // Formularios
                services.AddScoped<MainFormView>();
                services.AddScoped<EmprendimientosUc>();
                services.AddScoped<RegistroEmprendimientoView>();
                services.AddScoped<DetalleEmprendimientoView>();

                services.AddScoped<RegistroParticipantesView>();
                services.AddScoped<VerParticipantesView>();
                services.AddScoped<MainFormView>();
                services.AddScoped<ConsultaEmprendimientoUc>();
                services.AddScoped<CalendariodeActividadesView>();
                services.AddScoped<MainEstudianteView>();
                services.AddScoped<GestionAgendaView>();
                services.AddScoped<LogIn>();
                services.AddScoped<UserRegister>();
                services.AddScoped<GestionEventoView>();
                services.AddScoped<ResultadoEventoUc>();
                services.AddScoped<RegistroPremiacionView>();
                services.AddScoped<VotoEventoUc>();

                //options
                services.AddScoped<IViewRolUc, FacultadesUc>();
                services.AddScoped<IViewRolUc, RubroEmprendimientoUc>();

                //MainForms
                services.AddScoped<IViewRolForm, MainFormView>();
                services.AddScoped<IViewRolForm, MainEstudianteView>();

                // ventanas de eventos
            });
    }
}