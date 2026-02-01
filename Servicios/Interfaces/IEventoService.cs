using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Define operaciones de negocio para gestión de eventos y su agenda.
    /// </summary>
    public interface IEventoService
    {
        /// <summary>
        /// Crea un nuevo evento y registra la presentación inicial asociada.
        /// </summary>
        /// <param name="dto">Datos del evento a crear.</param>
        /// <returns>Resultado de la operación.</returns>
        Task<ResponseDto> CrearEventoAsync(EventoDto dto);

        /// <summary>
        /// Lista todos los eventos registrados.
        /// </summary>
        /// <returns>Colección de eventos en formato DTO.</returns>
        Task<List<EventoDto>> ListarEventosAsync();

        /// <summary>
        /// Lista emprendimientos disponibles para asignar como expositores.
        /// </summary>
        /// <returns>Colección de expositores (emprendimientos).</returns>
        Task<List<ExpositorDto>> ListarEmprendimientosAsync();
    }
}
