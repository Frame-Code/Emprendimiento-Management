using Modelo;
using Shared;

namespace Servicios.Interfaces;

/// <summary>
/// Servicio para administración del catálogo de rubros de emprendimiento.
/// </summary>
public interface IRubroEmprendimientoService
{
    /// <summary>Lista los rubros disponibles.</summary>
    public Task<List<RubroEmprendimiento>> ListarAsync();

    /// <summary>Crea un nuevo rubro.</summary>
    public Task CreateAsync(RubroEmprendimientoDto emprendimiento);
}
