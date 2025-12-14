using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Controller;

public class FacultadController(IFacultadService service)
{
    public async Task<List<Facultad>> ListarAsync() =>
        await service.ListarAsync();
    
    public async Task SaveAsync(FacultadDto entity) =>
        await service.SaveAsync(entity);
}