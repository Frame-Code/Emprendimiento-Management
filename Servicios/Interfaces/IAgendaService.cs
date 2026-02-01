using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Servicio para gestionar la agenda de presentaciones de los eventos.
    /// </summary>
    public interface IAgendaService
    {
        /// <summary>Registra una presentación en la agenda del evento.</summary>
        Task<ResponseDto> RegistrarAgendaPresentacionAsync(AgendaPresentacionDto dto);

        /// <summary>Obtiene la agenda ordenada por evento.</summary>
        Task<List<AgendaPresentacionDto>> ListarAgendaPorEventoAsync(int idEvento);

        /// <summary>Lista expositores disponibles para la agenda.</summary>
        Task<List<ExpositorDto>> ListarExpositoresAsync();
    }
}
