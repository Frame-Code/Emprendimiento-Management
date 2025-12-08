using Modelo;
using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CalendarioController(ICalendarioService calendarioService)
    {

        public async Task<List<CalendariodeActividadesDto>> ListarActividadesAsync() =>
            await calendarioService.ListarActividadesAsync();

        public async Task<List<CalendariodeActividadesDto>> FiltrarPorFacultadAsync(int idFacultad) =>
            await calendarioService.FiltrarPorFacultadAsync(idFacultad);

        public async Task<List<Facultad>> ListarFacultadesAsync() =>
            await calendarioService.ListarFacultadesAsync();

        public async Task<List<CalendariodeActividadesDto>> FiltrarPorFechaAsync(DateTime fecha) =>
            await calendarioService.FiltrarPorFechaAsync(fecha);
    }
}
