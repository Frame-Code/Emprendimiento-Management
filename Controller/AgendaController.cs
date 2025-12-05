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

        public async Task<ResponseDto> RegistrarCronogramaAsync(CronogramaDto dto) =>
            await _agendaService.RegistrarCronogramaAsync(dto);

        public async Task<ResponseDto> RegistrarPresentacionAsync(PresentacionDto dto) =>
            await _agendaService.RegistrarPresentacionAsync(dto);

        public async Task<List<CronogramaDto>> ListarCronogramasAsync() =>
            await _agendaService.ListarCronogramasAsync();

        public async Task<List<PresentacionDto>> ListarPresentacionesAsync() =>
            await _agendaService.ListarPresentacionesAsync();
    }
}