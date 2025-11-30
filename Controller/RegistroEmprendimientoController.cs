using Microsoft.Extensions.DependencyInjection;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Controller
{
    public class RegistroEmprendimientoController(IRegistroEmprendimientoService registroEmprendimientoService)
    {
        public async Task<List<RubroEmprendimiento>> ListarRubrosAsync() =>
            await registroEmprendimientoService.ListarRubrosAsync();

        public async Task<ResponseDto> RegistrarEmprendimientoAsync(RegistroEmprendimientoDto dto) =>
            await registroEmprendimientoService.RegistrarEmprendimientoAsync(dto);

        public async Task<List<Facultad>> ListarFacultadesAsync() =>
            await registroEmprendimientoService.ListarFacultadesAsync();

        public async Task<List<EmprendimientoDto>> ListarEmprendimientosAsync() =>
            await registroEmprendimientoService.ListarEmprendimientosAsync();
    }
}
