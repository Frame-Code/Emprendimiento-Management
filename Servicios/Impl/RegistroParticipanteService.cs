using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo;
using Datos.Interfaces;
using Shared;

namespace Servicios.Impl
{

    public class RegistroParticipanteService
    {

        private readonly IParticipanteRepository _participanteRepo;
        private readonly ICargoParticipanteRepository _cargoRepo;

        public RegistroParticipanteService(IParticipanteRepository participanteRepo, ICargoParticipanteRepository cargoRepo)
        {
            _participanteRepo = participanteRepo;
            _cargoRepo = cargoRepo;
        }

        public async Task<ResponseDto> RegistrarNuevoParticipante(ParticipanteDto dto)
        {
            var response = new ResponseDto();
            try
            {
                var nuevoParticipante = new Participante
                {
                    Nombres = dto.Nombres,
                    Apellidos = dto.Apellidos,
                    NumeroIdentificacion = dto.NoIdentificacion,
                    NumeroTelefono = dto.NoTelefono,
                    IdEmprendimiento = dto.IdEmprendimiento,
                    IdCargoParticipante = dto.IdCargoParticipante,
                    FotoPath = ""
                };

                await _participanteRepo.CreateAsync(nuevoParticipante);

                response.IsSuccess = true;
                response.Message = "Participante guardado con éxito.";
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error en el servicio de registro: " + ex.Message;
            }
            return response;
        }

        public async Task<List<CargoParticipante>> ObtenerListaCargos()
        {
            return await _cargoRepo.ListarAsync();
        }
    }
}