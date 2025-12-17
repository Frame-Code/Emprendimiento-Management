using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

public class RubroEmprendimientoService(IRubroEmprendimientoRepository repository) : IRubroEmprendimientoService
{
    public async Task<List<RubroEmprendimiento>> ListarAsync() =>
        await repository.ListarAsync();

    public async Task CreateAsync(RubroEmprendimientoDto emprendimiento)
    {
        var rubro = new RubroEmprendimiento
        {
            Nombre = emprendimiento.Nombre,
            Descripcion = emprendimiento.Description
        };
        
        await repository.CreateAsync(rubro);
    }
        
}