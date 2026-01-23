using Microsoft.Extensions.Hosting;
using Servicios.Impl;
using Servicios.Interfaces;
using Servicios.Reports;
using Shared.ViewRol;
using Controller;
using Datos.Impl;
using Datos.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using WinForms.Views;
using WinForms.Views.UserControls;
namespace WinForms.Config.Extensions;

public static class ServicesExtensions
{
    public static IHostBuilder AddServices(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureServices((context, services) =>
        {
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
            services.AddScoped<IUsuarioRepository, UsuarioRepositoryImpl>();
            services.AddScoped<IRolUsuarioRepository, RolUsuarioRepositoryImpl>();
            services.AddScoped<IMenuOpcionesRepository, MenuOpcionesRepository>();
            services.AddScoped<IFotoRepository, FotoRepositoryImpl>();
            services.AddScoped<IPremiacionRepository, PremiacionRepositoryImpl>();
            services.AddScoped<IComentarioRepository, ComentarioRepositoryImpl>();
            services.AddScoped<ISpExecutor, SpExecutor>();

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
            services.AddScoped<IComentarioService, ComentarioServiceImpl>();

            services.AddScoped<IPdfReportGenerator, PdfReportGeneratorImpl>();
            services.AddScoped<IReport, PremiacionReportPdf>();
            services.AddScoped<IFotoService, FotoServiceImpl>();
            services.AddTransient<IViewRolForm, MainEstudianteView>();
            

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
            services.AddScoped<ComentarioController>();


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
            services.AddScoped<GaleriaEmprendimientoView>();

            //options
            services.AddScoped<IViewRolUc, FacultadesUc>();
            services.AddScoped<IViewRolUc, RubroEmprendimientoUc>();

            //MainForms
            services.AddScoped<IViewRolForm, MainFormView>();
            services.AddScoped<IViewRolForm, MainEstudianteView>();
        });
    }
}