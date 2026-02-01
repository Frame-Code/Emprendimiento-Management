using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Servicio para consulta del calendario de actividades por criterios.
    /// </summary>
    public interface ICalendarioService
    {
        /// <summary>Lista todas las actividades registradas.</summary>
        Task<List<CalendariodeActividadesDto>> ListarActividadesAsync();

        /// <summary>Filtra actividades por facultad.</summary>
        Task<List<CalendariodeActividadesDto>> FiltrarPorFacultadAsync(int idFacultad);

        /// <summary>Lista las facultades disponibles para filtrar.</summary>
        Task<List<Facultad>> ListarFacultadesAsync();

        /// <summary>Filtra actividades por fecha (inicio o fin).</summary>
        Task<List<CalendariodeActividadesDto>> FiltrarPorFechaAsync(DateTime fecha);
    }
}
