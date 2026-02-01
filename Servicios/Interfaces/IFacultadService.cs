using Modelo;
using Shared;

namespace Servicios.Interfaces;

/// <summary>
/// Servicio para administración del catálogo de Facultades.
/// </summary>
public interface IFacultadService
{
    /// <summary>Lista todas las facultades.</summary>
    public Task<List<Facultad>> ListarAsync();

    /// <summary>Guarda una nueva facultad.</summary>
    public Task SaveAsync(FacultadDto entity);
}
