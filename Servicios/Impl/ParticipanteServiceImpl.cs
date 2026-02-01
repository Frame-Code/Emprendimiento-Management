using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AppContext = Datos.AppContext;

namespace Servicios.Impl
{
    /// <summary>
    /// Implementación del servicio de participantes: asociación a emprendimientos y listados.
    /// </summary>
    public class ParticipanteServiceImpl(
        IParticipanteRepository participanteRepository,
        ICargoParticipanteRepository cargoParticipanteRepository,
        IEmprendimientoRepository emprendimientoRepository
        ) : IParticipanteService
    {
        /// <inheritdoc />
        public async Task<ResponseDto> AgregarParticipante(int idParticipante, int idEmprendimiento)
        {
            var participantes = await participanteRepository.ListarAsync();
            var participanteValidate = participantes.FirstOrDefault(p => p.Id == idParticipante);
            if (participanteValidate == null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Error, participante no ha sido encontrado."
                };
            }

            var emprendimiento = await emprendimientoRepository.ObtenerPorIdAsync(idEmprendimiento);
            if (emprendimiento == null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Error, Emprendimiento no ha sido encontrado."
                };
            }
            
            participanteValidate.IdEmprendimiento = idEmprendimiento;
            await participanteRepository.UpdateAsync(participanteValidate);
            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Participante agregado exitosamente.",
                Data = participanteValidate
            };
        }

        /// <inheritdoc />
        public async Task<List<CargoParticipante>> ListarCargos() =>
            await cargoParticipanteRepository.ListarAsync();

        /// <inheritdoc />
        public async Task<List<VerParticipantesDto>> ListarParticipantes()
        {
            var list = await participanteRepository.ListarAsync();
            var participantes = list.Select(par => new VerParticipantesDto
            {
                Id = par.Id,
                Nombre = par.Nombres,
                Apellido = par.Apellidos,
                CargoParticipante = par.CargoParticipante.Nombre,
                Identificacion = par.NumeroIdentificacion,
                Telefono = par.NumeroTelefono
            });
            return participantes.ToList();
        }

        /// <inheritdoc />
        public async Task<List<string>> ObtenerNombresParticipantes(int idEmprendimiento)
        {
            var list = await participanteRepository.ListarAsync();
            var nombres = list
                .Where(p => p.IdEmprendimiento == idEmprendimiento)
                .Select(p => p.NombresCompletos + "... #Identificacion: " + p.NumeroIdentificacion + "... Cargo: " + p.CargoParticipante.Nombre)
                .ToList();
            return nombres;
        }
    }
}
