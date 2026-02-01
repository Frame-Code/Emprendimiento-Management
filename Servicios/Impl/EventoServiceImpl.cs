using Datos.Interfaces;
using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces;


namespace Servicios.Impl
{
    /// <summary>
    /// Implementación de <see cref="IEventoService"/> para creación y consulta de eventos,
    /// así como utilidades para listar expositores.
    /// </summary>
    public class EventoServiceImpl : IEventoService
    {
        private readonly IEventoRepository _eventoRepository;
        private readonly IAgendaPresentacionRepository _agendaPresentacionRepository;
        private readonly IEmprendimientoRepository _emprendimientoRepository;

        public EventoServiceImpl(
            IEventoRepository eventoRepository,
            IAgendaPresentacionRepository agendaPresentacionRepository,
            IEmprendimientoRepository emprendimientoRepository)
        {
            _eventoRepository = eventoRepository;
            _agendaPresentacionRepository = agendaPresentacionRepository;
            _emprendimientoRepository = emprendimientoRepository;
        }

        /// <summary>
        /// Crea un evento y registra su primera presentación en la agenda.
        /// </summary>
        /// <param name="dto">Datos del evento y el emprendimiento expositor.</param>
        /// <returns>Resultado de la operación.</returns>
        public async Task<ResponseDto> CrearEventoAsync(EventoDto dto)
        {
            var evento = new Evento
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                FechaInicio = dto.FechaInicio,
                FechaFin = dto.FechaFin,
                Ubicacion = dto.Ubicacion
            };

            await _eventoRepository.CreateAsync(evento);

            var agenda = new AgendaPresentacion
            {
                IdEvento = evento.Id,
                IdEmprendimiento = dto.IdEmprendimiento,
                Orden = 1
            };

            await _agendaPresentacionRepository.CreateAsync(agenda);

            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Evento creado correctamente"
            };
        }

        /// <summary>
        /// Lista los emprendimientos disponibles como expositores.
        /// </summary>
        /// <returns>Listado de expositores.</returns>
        public async Task<List<ExpositorDto>> ListarExpositoresAsync()
        {
            var emprendimientos = await _emprendimientoRepository.ListarAsync();

            return emprendimientos.Select(e => new ExpositorDto
            {
                Id = e.Id,
                Nombre = e.Nombre
            }).ToList();
        }

        /// <summary>
        /// Obtiene el listado de eventos.
        /// </summary>
        /// <returns>Listado de eventos en formato DTO.</returns>
        public async Task<List<EventoDto>> ListarEventosAsync()
        {
            var lista = await _eventoRepository.ListarAsync();

            return lista.Select(e => new EventoDto
            {
                Id = e.Id,
                Nombre = e.Nombre,
                Descripcion = e.Descripcion,
                FechaInicio = e.FechaInicio,
                FechaFin = e.FechaFin,
                Ubicacion = e.Ubicacion?? "-"
            }).ToList();
        }
        /// <summary>
        /// Lista emprendimientos (alias de <see cref="ListarExpositoresAsync"/>).
        /// </summary>
        /// <returns>Listado de emprendimientos.</returns>
        public async Task<List<ExpositorDto>> ListarEmprendimientosAsync()
        {
            var emprendimientos = await _emprendimientoRepository.ListarAsync();

            return emprendimientos.Select(e => new ExpositorDto
            {
                Id = e.Id,
                Nombre = e.Nombre
            }).ToList();
        }

    }
}
