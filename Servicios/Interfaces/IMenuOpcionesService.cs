using Modelo.Properties;
using Shared;

namespace Servicios.Interfaces;

/// <summary>
/// Servicio para consulta de opciones de menú por grupo y rol.
/// </summary>
public interface IMenuOpcionesService
{
    /// <summary>Lista opciones de menú de un grupo específico y rol.</summary>
    public Task<List<MenuOpciones>> ListarPorGrupo(string grupo, string rolCode);

    /// <summary>Lista opciones de menú disponibles para un rol.</summary>
    public Task<List<MenuOptionsDto>> ListarPorRol(string rolCode);
}
