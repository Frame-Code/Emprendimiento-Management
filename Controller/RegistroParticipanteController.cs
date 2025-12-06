using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo;
using Shared;
using Servicios.Impl;

namespace Controller
{

    public class RegistroParticipanteController
    {
        private readonly RegistroParticipanteService _servicioExclusivo;

        public RegistroParticipanteController(RegistroParticipanteService servicio)
        {
            _servicioExclusivo = servicio;
        }

        public async Task<List<CargoParticipante>> CargarCargosParaCombo()
        {
            return await _servicioExclusivo.ObtenerListaCargos();
        }

        public async Task<ResponseDto> GuardarParticipante(ParticipanteDto dto)
        {
            if (dto == null) return new ResponseDto { IsSuccess = false, Message = "Datos vacíos" };

            return await _servicioExclusivo.RegistrarNuevoParticipante(dto);
        }
    }
}