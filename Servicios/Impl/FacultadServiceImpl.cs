using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

public class FacultadServiceImpl(IFacultadRepository repository): IFacultadService
{
    public async Task<List<Facultad>> ListarAsync() =>
        await repository.ListarAsync();

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