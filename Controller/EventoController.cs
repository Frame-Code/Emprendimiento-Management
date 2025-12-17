using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces;


namespace Controller
{
    public class EventoController
    {
        private readonly IEventoService _eventoService;

        public EventoController(IEventoService eventoService)
        {
            _eventoService = eventoService;
        }

        public Task<ResponseDto> CrearEventoAsync(EventoDto dto)
            => _eventoService.CrearEventoAsync(dto);

        public Task<List<EventoDto>> ListarEventosAsync()
            => _eventoService.ListarEventosAsync();

        public Task<List<ExpositorDto>> ListarEmprendimientosAsync()
            => _eventoService.ListarEmprendimientosAsync();
    }
}