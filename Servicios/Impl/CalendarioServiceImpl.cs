using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Servicios.Impl
{
    /// <summary>
    /// Implementación del servicio de calendario de actividades.
    /// </summary>
    public class CalendarioServiceImpl(
        IAgendaPresentacionRepository agendaPresentacionRepository,
        IFacultadRepository facultadRepository
    ) : ICalendarioService
    {
        /// <inheritdoc />
        public async Task<List<CalendariodeActividadesDto>> ListarActividadesAsync()
        {
            var presentaciones = await agendaPresentacionRepository.ListarAsync();

            return presentaciones.Select(e => new CalendariodeActividadesDto
            {
                NombreEvento = e.Evento.Nombre,
                FechaInicio = e.Evento.FechaInicio,
                FechaFin = e.Evento.FechaFin,
                Facultad = e.Emprendimiento.Facultad?.Nombre ?? "Sin Facultad"
            }).ToList();
        }

        /// <inheritdoc />
        public async Task<List<CalendariodeActividadesDto>> FiltrarPorFacultadAsync(int idFacultad)
        {
            var presentaciones = await agendaPresentacionRepository.ListarAsync();

            return presentaciones
                .Where(e => e.Emprendimiento.Facultad.Id == idFacultad)
                .Select(e => new CalendariodeActividadesDto
                {
                    NombreEvento = e.Evento.Nombre,
                    FechaInicio = e.Evento.FechaInicio,
                    FechaFin = e.Evento.FechaFin,
                    Facultad = e.Emprendimiento.Facultad?.Nombre ?? "Sin Facultad"
                }).ToList();
        }

        /// <inheritdoc />
        public async Task<List<Facultad>> ListarFacultadesAsync()
        {
            return await facultadRepository.ListarAsync();
        }

        /// <inheritdoc />
        public async Task<List<CalendariodeActividadesDto>> FiltrarPorFechaAsync(DateTime fecha)
        {
            var presentaciones = await agendaPresentacionRepository.ListarAsync();

            return presentaciones
                .Where(e => e.Evento.FechaInicio.Date == fecha.Date || e.Evento.FechaFin.Date == fecha.Date)
                .Select(e => new CalendariodeActividadesDto
                {
                    NombreEvento = e.Evento.Nombre,
                    FechaInicio = e.Evento.FechaInicio,
                    FechaFin = e.Evento.FechaFin,
                    Facultad = e.Emprendimiento.Facultad?.Nombre ?? "Sin Facultad"
                }).ToList();
        }
    }
}
