using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AgendaController(IAgendaService agendaService)
    {
        public async Task<ResponseDto> RegistrarCronogramaAsync(CronogramaDto dto) =>
            await agendaService.RegistrarCronogramaAsync(dto);

        public async Task<ResponseDto> RegistrarPresentacionAsync(PresentacionDto dto) =>
            await agendaService.RegistrarPresentacionAsync(dto);

        public async Task<List<CronogramaDto>> ListarCronogramasAsync() =>
            await agendaService.ListarCronogramasAsync();

        public async Task<List<PresentacionDto>> ListarPresentacionesAsync() =>
            await agendaService.ListarPresentacionesAsync();
    }
}