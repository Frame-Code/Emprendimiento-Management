using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface IParticipanteService
    {
        Task<List<string>> ObtenerNombresParticipantes(int idEmprendimiento);
        Task<ResponseDto> AgregarParticipante(int idParticipante, int idEmprendimiento);
        Task<List<CargoParticipante>> ListarCargos();
        Task<List<VerParticipantesDto>> ListarParticipantes();
    }
}
