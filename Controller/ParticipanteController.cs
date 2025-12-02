using Modelo;
using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ParticipanteController(IParticipanteService participanteService)
    {
        public async Task<List<string>> ObtenerNombresParticipantes(int idEmprendimiento) =>
            await participanteService.ObtenerNombresParticipantes(idEmprendimiento);

        public async Task<ResponseDto> AgregarParticipante(ParticipanteDto participanteDto) =>
            await participanteService.AgregarParticipante(participanteDto);

        public async Task<List<CargoParticipante>> ListarCargos() =>
            await participanteService.ListarCargos();
    }
}
