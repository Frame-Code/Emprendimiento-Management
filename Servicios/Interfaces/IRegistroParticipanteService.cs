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
    /// Servicio para registro y consulta de participantes.
    /// </summary>
    public interface IRegistroParticipanteService
    {
        /// <summary>Registra un nuevo participante y su foto.</summary>
        public Task<ResponseDto> RegistrarNuevoParticipante(ParticipanteDto dto);

        /// <summary>Obtiene el catálogo de cargos de participantes.</summary>
        public Task<List<CargoParticipante>> ObtenerListaCargos();

        /// <summary>Lista todos los participantes registrados.</summary>
        public Task<List<Participante>> ObtenerTodos();
    }
}
