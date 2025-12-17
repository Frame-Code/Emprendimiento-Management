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
        private readonly IAgendaService _service;

        public AgendaController(IAgendaService service)
        {
            _service = service;
        }

        public Task<ResponseDto> RegistrarAgendaPresentacionAsync(AgendaPresentacionDto dto)
            => _service.RegistrarAgendaPresentacionAsync(dto);

        public Task<List<AgendaPresentacionDto>> ListarAgendaPorEventoAsync(int idEvento)
            => _service.ListarAgendaPorEventoAsync(idEvento);

        public Task<List<ExpositorDto>> ListarExpositoresAsync()
            => _service.ListarExpositoresAsync();
    }
}