using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface IRegistroParticipanteService
    {
        public Task<ResponseDto> RegistrarNuevoParticipante(ParticipanteDto dto);
        public Task<List<CargoParticipante>> ObtenerListaCargos();
        public Task<List<Participante>> ObtenerTodos();

    }
}
