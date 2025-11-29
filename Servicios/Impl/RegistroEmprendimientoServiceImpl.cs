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
    internal class RegistroEmprendimientoServiceImpl (
        IEmprendimientoRepository emprendimientoRepository, 
        IRubroEmprendimientoRepository rubroEmprendimientoRepository,
        IFacultadRepository facultadRepository) : IRegistroEmprendimientoService
    {
        public async Task<List<Facultad>> ListarFacultadesAsync() => 
            await facultadRepository.ListarAsync();

        public async Task<List<RubroEmprendimiento>> ListarRubrosAsync() =>
            await rubroEmprendimientoRepository.ListarAsync();

        public async Task<ResponseDto> RegistrarEmprendimientoAsync(RegistroEmprendimientoDto dto)
        {
            var rubro = await rubroEmprendimientoRepository.ObtenerPorIdAsync(dto.IdRubroEmprendimiento);
            var facultad = await facultadRepository.ObtenerPorIdAsync(dto.IdFacultad);

            if(rubro is null || facultad is null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Rubro o Facultad no encontrados"
                };
            }

            var emprendimiento = new Emprendimiento
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                IdFacultad = rubro.Id,
                IdRubroEmprendimiento = facultad.Id
            };

            //Crear el emprendimiento
            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Emprendimiento creado con exito"
            };

        }
    }
}
