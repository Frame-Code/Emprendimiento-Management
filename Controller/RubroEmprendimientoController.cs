using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Controller;

public class RubroEmprendimientoController(IRubroEmprendimientoService service)
{
    public async Task<List<RubroEmprendimiento>> ListarAsync() =>
        await service.ListarAsync();

    public async Task CreateAsync(RubroEmprendimientoDto emprendimiento) =>
        await service.CreateAsync(emprendimiento);
}