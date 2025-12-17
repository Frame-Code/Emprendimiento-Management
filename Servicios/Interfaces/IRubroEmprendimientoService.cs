using Modelo;
using Shared;

namespace Servicios.Interfaces;

public interface IRubroEmprendimientoService
{
    public Task<List<RubroEmprendimiento>> ListarAsync();
    public Task CreateAsync(RubroEmprendimientoDto emprendimiento);
}