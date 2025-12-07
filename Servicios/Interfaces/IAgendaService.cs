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
        Task<ResponseDto> RegistrarCronogramaAsync(CronogramaDto dto);
        Task<ResponseDto> RegistrarPresentacionAsync(PresentacionDto dto);
        Task<List<CronogramaDto>> ListarCronogramasAsync();
        Task<List<PresentacionDto>> ListarPresentacionesAsync();
        Task<List<ExpositorDto>> ListarExpositoresAsync();
    }
}