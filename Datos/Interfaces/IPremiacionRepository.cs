using Modelo;
using Shared;

namespace Datos.Interfaces;

public interface IPremiacionRepository : IRepository<Premiacion>
{
    Task UpdatePremiacion(Premiacion premiacion);
    Task<Premiacion?> ObtenerPremiacionDisponible();
}