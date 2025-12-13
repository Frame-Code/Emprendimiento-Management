using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Modelo;
using Datos.Interfaces;
using Shared;
using Servicios.Interfaces;

namespace Servicios.Impl
{

    public class RegistroParticipanteService : IRegistroParticipanteService
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
                if (await _participanteRepo.ExisteIdentificacionAsync(dto.NoIdentificacion))
                {
                    response.IsSuccess = false;
                    response.Message = "Ya existe un participante con esa identificación.";
                    return response;
                }
                if (await _participanteRepo.ExisteTelefonoAsync(dto.NoTelefono))
                {
                    response.IsSuccess = false;
                    response.Message = "Ya existe un participante con ese número de teléfono.";
                    return response;
                }

                var nuevoParticipante = new Participante
                {
                    Nombres = dto.Nombres,
                    Apellidos = dto.Apellidos,
                    NumeroIdentificacion = dto.NoIdentificacion,
                    NumeroTelefono = dto.NoTelefono,
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

        public async Task<List<Participante>> ObtenerTodos()
        {          
            return await _participanteRepo.ListarAsync();
        }

        public async Task<List<CargoParticipante>> ObtenerListaCargos()
        {
            return await _cargoRepo.ListarAsync();
        }
    }
}