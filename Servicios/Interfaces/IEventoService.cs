using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface IEventoService
    {
        Task<ResponseDto> CrearEventoAsync(EventoDto dto);
        Task<List<EventoDto>> ListarEventosAsync();
        Task<List<ExpositorDto>> ListarEmprendimientosAsync();
    }
}
