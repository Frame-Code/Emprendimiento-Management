using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo;
using Shared;
using Servicios.Impl;
using Servicios.Interfaces;
using Datos.Interfaces;

namespace Controller
{

    public class RegistroParticipanteController
    {
        private readonly IRegistroParticipanteService _servicioExclusivo;
        private readonly ISpExecutor _spExecutor;

        public RegistroParticipanteController(IRegistroParticipanteService servicio, ISpExecutor spExecutor)
        {
            _servicioExclusivo = servicio;
            _spExecutor = spExecutor;
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

        public async Task<List<Participante>> ObtenerTodos()
        {
            return await _servicioExclusivo.ObtenerTodos();

        }
        

    public async Task<List<VerParticipantesDto>> ObtenerParticipantesVista()
        {
            var lista = await _spExecutor.ConsultarParticipantes();
            return lista.ToList();
        }
    }
}