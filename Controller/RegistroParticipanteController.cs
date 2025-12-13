using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo;
using Shared;
using Servicios.Impl;
using Servicios.Interfaces;

namespace Controller
{

    public class RegistroParticipanteController
    {
        private readonly IRegistroParticipanteService _servicioExclusivo;

        public RegistroParticipanteController(IRegistroParticipanteService servicio)
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

        public async Task<List<Participante>> ObtenerTodos()
        {
            return await _servicioExclusivo.ObtenerTodos();

        }
        

    public async Task<List<VerParticipantesDto>> ObtenerParticipantesVista()
        {
            var lista = await _servicioExclusivo.ObtenerTodos();

            return lista.Select(p => new VerParticipantesDto
            {
                Nombre = p.Nombres,
                Apellido = p.Apellidos,
                Telefono = p.NumeroTelefono,
                Identificacion = p.NumeroIdentificacion
            }).ToList();
        }
    }
}