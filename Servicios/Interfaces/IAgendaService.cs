using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface IAgendaService
    {
        Task<ResponseDto> RegistrarAgendaPresentacionAsync(AgendaPresentacionDto dto);
        Task<List<AgendaPresentacionDto>> ListarAgendaPorEventoAsync(int idEvento);
        Task<List<ExpositorDto>> ListarExpositoresAsync();
    }
}