using Microsoft.Extensions.DependencyInjection;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Controller
{
    public class EmprendimientoController(IEmprendimientoService emprendimientoService)
    {
        public async Task<List<RubroEmprendimiento>> ListarRubrosAsync() =>
            await emprendimientoService.ListarRubrosAsync();

        public async Task<ResponseDto> RegistrarEmprendimientoAsync(RegistroEmprendimientoDto dto) =>
            await emprendimientoService.RegistrarEmprendimientoAsync(dto);

        public async Task<List<Facultad>> ListarFacultadesAsync() =>
            await emprendimientoService.ListarFacultadesAsync();

        public async Task<List<EmprendimientoDto>> ListarEmprendimientosAsync() =>
            await emprendimientoService.ListarEmprendimientosAsync();

        public async Task DeleteByIdAsync(int id) =>
            await emprendimientoService.DeleteByIdAsync(id);

        public async Task<Emprendimiento?> ObtenerPorIdAsync(int id) =>
            await emprendimientoService.ObtenerPorIdAsync(id);

        public async Task<List<Emprendimiento>> ListarEmprendimientosEstudiantesAsync() =>
            await emprendimientoService.ListarEmprendimientosEstudiantesAsync();
    }
}
