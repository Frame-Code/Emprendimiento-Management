using Datos;
using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;
using AppContext = Datos.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Impl
{
    public class EmprendimientoServiceImpl(
        IEmprendimientoRepository emprendimientoRepository,
        IRubroEmprendimientoRepository rubroEmprendimientoRepository,
        IFacultadRepository facultadRepository) : IEmprendimientoService
    {
        public async Task DeleteByIdAsync(int id) =>
            await emprendimientoRepository.DeleteByIdAsync(id);

        public async Task<List<EmprendimientoDto>> ListarEmprendimientosAsync()
        {
            var emprendimientos = await emprendimientoRepository.ListarAsync();

            return emprendimientos
                .Select(e => new EmprendimientoDto
                {
                    Id = e.Id,
                    Nombre = e.Nombre,
                    Descripcion = e.Descripcion,
                    Facultad = e.Facultad?.Nombre ?? "Sin Facultad",
                    Rubro = e.RubroEmprendimiento?.Nombre ?? "Sin Rubro"
                })
                .ToList();
        }

        public async Task<List<Facultad>> ListarFacultadesAsync() =>
            await facultadRepository.ListarAsync();

        public async Task<List<RubroEmprendimiento>> ListarRubrosAsync() =>
            await rubroEmprendimientoRepository.ListarAsync();

        public async Task<ResponseDto> RegistrarEmprendimientoAsync(RegistroEmprendimientoDto dto)
        {
            var rubro = await rubroEmprendimientoRepository.ObtenerPorIdAsync(dto.IdRubroEmprendimiento);
            var facultad = await facultadRepository.ObtenerPorIdAsync(dto.IdFacultad);

            if (rubro is null || facultad is null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "Rubro o Facultad no encontrados"
                };
            }

           
            var fotos = dto.fotos
                .Select(ft => new Foto
                {
                    FileName = ft.FileName,
                    FileExtension = ft.FileExtension,
                    ImageUrl = ft.Url
                })
                .ToList();

            var emprendimiento = new Emprendimiento
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                IdFacultad = facultad.Id,
                IdRubroEmprendimiento = rubro.Id,
                Fotos = fotos
            };

            await emprendimientoRepository.CreateAsync(emprendimiento);

            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Emprendimiento creado con éxito"
            };
        }

        public async Task<List<Emprendimiento>> ListarEmprendimientosEstudiantesAsync()
        {
           
            return await emprendimientoRepository.ListarAsync();
        }

        public async Task<Emprendimiento?> ObtenerPorIdAsync(int id)
        {
           
            return await emprendimientoRepository.ObtenerPorIdAsync(id);
        }
    }
}