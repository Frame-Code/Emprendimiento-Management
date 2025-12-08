using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface ICalendarioService
    {
        Task<List<CalendariodeActividadesDto>> ListarActividadesAsync();
        Task<List<CalendariodeActividadesDto>> FiltrarPorFacultadAsync(int idFacultad);
        Task<List<Facultad>> ListarFacultadesAsync();
        Task<List<CalendariodeActividadesDto>> FiltrarPorFechaAsync(DateTime fecha);
    }
}
