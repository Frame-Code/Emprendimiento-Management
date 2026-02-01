using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Servicios para administración de participantes y sus cargos.
    /// </summary>
    public interface IParticipanteService
    {
        /// <summary>
        /// Obtiene la lista de nombres formateados de los participantes de un emprendimiento.
        /// </summary>
        Task<List<string>> ObtenerNombresParticipantes(int idEmprendimiento);

        /// <summary>
        /// Asocia un participante existente a un emprendimiento.
        /// </summary>
        Task<ResponseDto> AgregarParticipante(int idParticipante, int idEmprendimiento);

        /// <summary>Lista los cargos disponibles para participantes.</summary>
        Task<List<CargoParticipante>> ListarCargos();

        /// <summary>Lista participantes en formato resumido para visualización.</summary>
        Task<List<VerParticipantesDto>> ListarParticipantes();
    }
}
