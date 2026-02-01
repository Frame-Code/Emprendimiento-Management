using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

/// <summary>
/// Implementación del servicio de rubros de emprendimiento.
/// </summary>
public class RubroEmprendimientoService(IRubroEmprendimientoRepository repository) : IRubroEmprendimientoService
{
    /// <inheritdoc />
    public async Task<List<RubroEmprendimiento>> ListarAsync() =>
        await repository.ListarAsync();

    /// <inheritdoc />
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
