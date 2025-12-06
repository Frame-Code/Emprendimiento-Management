using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Impl
{
    public class ParticipanteServiceImpl(
        IParticipanteRepository participanteRepository,
        ICargoParticipanteRepository cargoParticipanteRepository,
        IEmprendimientoRepository emprendimientoRepository
        ) : IParticipanteService
    {
        public async Task<ResponseDto> AgregarParticipante(ParticipanteDto participanteDto)
        {
            var participantes = await participanteRepository.ListarAsync();
            var participanteValidate = participantes.FirstOrDefault(p => p.NumeroIdentificacion == participanteDto.NoIdentificacion || p.NumeroTelefono == participanteDto.NoTelefono);
            if (participanteValidate != null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Ya existe un participante con el mismo número de identificación."
                };
            }

            var emprendimiento = await emprendimientoRepository.ObtenerPorIdAsync(participanteDto.IdEmprendimiento);
            var cargo = await cargoParticipanteRepository.ObtenerPorIdAsync(participanteDto.IdCargoParticipante);
            if (emprendimiento == null || cargo == null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Emprendimiento o cargo de participante no encontrado."
                };
            }
            var participante = new Participante
            {
                Nombres = participanteDto.Nombres,
                Apellidos = participanteDto.Apellidos,
                NumeroIdentificacion = participanteDto.NoIdentificacion,
                NumeroTelefono = participanteDto.NoTelefono,
                IdEmprendimiento = participanteDto.IdEmprendimiento,
                IdCargoParticipante = participanteDto.IdCargoParticipante
            };
            await participanteRepository.CreateAsync(participante);
            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Participante agregado exitosamente.",
                Data = participante
            };
        }

        public async Task<List<CargoParticipante>> ListarCargos() =>
            await cargoParticipanteRepository.ListarAsync();

        public async Task<List<string>> ObtenerNombresParticipantes(int idEmprendimiento)
        {
            var list = await participanteRepository.ListarAsync();
            var nombres = list
                .Where(p => p.IdEmprendimiento == idEmprendimiento)
                .Select(p => p.NombresCompletos + "... #Identificacion: " + p.NumeroIdentificacion + "... Cargo: " + p.cargoParticipante.Nombre)
                .ToList();
            return nombres;
        }
    }
}
