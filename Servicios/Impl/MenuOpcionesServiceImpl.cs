using System.ComponentModel.Design;
using Datos.Interfaces;
using Modelo.Properties;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

/// <summary>
/// Implementación del servicio de opciones de menú.
/// </summary>
public class MenuOpcionesServiceImpl(IMenuOpcionesRepository menuOpcionesRepository) : IMenuOpcionesService
{
    /// <inheritdoc />
    public async Task<List<MenuOpciones>> ListarPorGrupo(string grupo, string rolCode) =>
        await menuOpcionesRepository.ListarPorGrupo(grupo, rolCode);

    /// <inheritdoc />
    public async Task<List<MenuOptionsDto>> ListarPorRol(string rolCode)
    {
        var options = await menuOpcionesRepository.ListarPorRol(rolCode);
        return options
            .Select(opt => 
                new MenuOptionsDto
                {
                    Nombre = opt.Nombre,
                    Code = opt.Code,
                    Grupo = opt.Grupo
                })
            .ToList();
    }
        
}
