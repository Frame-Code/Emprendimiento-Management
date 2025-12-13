using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AgendaController
    {
        private readonly IAgendaService _agendaService;

        public AgendaController(IAgendaService agendaService)
        {
            _agendaService = agendaService;
        }

        public async Task<ResponseDto> RegistrarAgendaPresentacionAsync(AgendaPresentacionDto dto)
            => await _agendaService.RegistrarAgendaPresentacionAsync(dto);

        public async Task<List<AgendaPresentacionDto>> ListarAgendaPorEventoAsync(int idEvento)
            => await _agendaService.ListarAgendaPorEventoAsync(idEvento);

        public async Task<List<ExpositorDto>> ListarExpositoresAsync()
            => await _agendaService.ListarExpositoresAsync();
    }
}