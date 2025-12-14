using Modelo;
using Shared;

namespace Servicios.Interfaces;

public interface IFacultadService
{
    public Task<List<Facultad>> ListarAsync();
    public Task SaveAsync(FacultadDto entity);
}