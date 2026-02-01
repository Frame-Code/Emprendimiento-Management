using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

/// <summary>
/// Implementación del servicio de Facultades.
/// </summary>
public class FacultadServiceImpl(IFacultadRepository repository): IFacultadService
{
    /// <inheritdoc />
    public async Task<List<Facultad>> ListarAsync() =>
        await repository.ListarAsync();

    /// <inheritdoc />
    public async Task SaveAsync(FacultadDto entity)
    {
        var facultad = new Facultad
        {
            Nombre = entity.Nombre,
            Descripcion = entity.Description
        };
        await repository.CreateAsync(facultad);
    }
        
}
