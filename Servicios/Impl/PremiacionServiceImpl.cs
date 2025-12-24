using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

public class PremiacionServiceImpl(IPremiacionRepository repository, IEmprendimientoRepository emprendimientoRepository) : IPremiacionService
{
    public async Task<List<PremiacionDto>> ListarPremiacionesAsync()
    {
        var premiaciones = await repository.ListarAsync();
        return premiaciones.Select(p => 
            new PremiacionDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                FechaInicioPremiacion = p.FechaInicioPremiacion,
                FechaFinPremiacion = p.FechaFinPremiacion,
                EmprendimientosDto = p.Emprendimientos
                    .Select(e => new EmprendimientoDto
                    {
                        Nombre    = e.Emprendimiento.Nombre,
                        Descripcion = e.Emprendimiento.Descripcion,
                        Facultad = e.Emprendimiento.Facultad.Nombre,
                        Rubro = e.Emprendimiento.RubroEmprendimiento.Nombre
                    }).ToList(),
                Votos = p.Votos
                    .Select(v => new VotoDto
                    {
                        FechaCreacion   = v.Voto.FechaCreacion,
                        NombreEmprendimiento = v.Voto.Emprendimiento.Nombre,
                        NombreUsuario = v.Voto.Usuario.NombreUsuario,
                        NombreRol = v.Voto.Usuario.RolUsuario.Nombre
                    }).ToList()
            })
            .ToList();
    }

    public async Task<PremiacionDto?> ObtenerPremiacionPorIdAsync(int id)
    {
        var premiacion = await repository.ObtenerPorIdAsync(id);
        if (premiacion == null)
            return null;
        
        var emprendimientoVotosDto = premiacion.Votos
            .ToList()
            .GroupBy(p => p.Voto.Emprendimiento)
            .Select(p => new EmprendimientoVotoDto
            {
                IdEmprendimiento = p.Key.Id,
                Nombre = p.Key.Nombre,
                Facultad = p.Key.Facultad.Nombre,
                Rubro = p.Key.RubroEmprendimiento.Nombre,
                CantidadVotos = p.Count()
            })
            .ToList();
        
        var emprendimientosSinVoto = premiacion.Emprendimientos
            .ToList()
            .GroupBy(p => p.Emprendimiento)
            .Select(p => new EmprendimientoVotoDto
            {
                IdEmprendimiento = p.Key.Id,
                Nombre = p.Key.Nombre,
                Facultad = p.Key.Facultad.Nombre,
                Rubro = p.Key.RubroEmprendimiento.Nombre,
                CantidadVotos = 0
            })
            .ToList();

        var emprendimientosSinVotoUnicos = emprendimientosSinVoto
            .Where(x => emprendimientoVotosDto.All(p => p.IdEmprendimiento != x.IdEmprendimiento));
        
        emprendimientoVotosDto.AddRange(emprendimientosSinVotoUnicos);
        
        
        return new PremiacionDto
        {
            Id = premiacion.Id,
            Nombre = premiacion.Nombre,
            FechaCreacion = premiacion.FechaCreacion,
            FechaFinPremiacion = premiacion.FechaFinPremiacion,
            FechaInicioPremiacion = premiacion.FechaInicioPremiacion,
            EmprendimientosDto = premiacion.Emprendimientos
                .Select(e => new EmprendimientoDto
                {
                    Nombre = e.Emprendimiento.Nombre,
                    Descripcion = e.Emprendimiento.Descripcion,
                    Facultad = e.Emprendimiento.Facultad.Nombre,
                    Rubro = e.Emprendimiento.RubroEmprendimiento.Nombre
                }).ToList(),
            Votos = premiacion.Votos
                .Select(v => new VotoDto
                {
                    FechaCreacion = v.Voto.FechaCreacion,
                    NombreEmprendimiento = v.Voto.Emprendimiento.Nombre,
                    NombreUsuario = v.Voto.Usuario.NombreUsuario,
                    NombreRol = v.Voto.Usuario.RolUsuario.Nombre
                }).ToList(),
            EmprendimientoVoto = emprendimientoVotosDto.ToList()
        };
    }

    public async Task<ResponseDto> CrearPremiacionAsync(PremiacionDto dto)
    {
        var emprendimientos = await emprendimientoRepository.ListarAsync();
        var empCoincidentes = emprendimientos.Where(x => dto.EmprendimientosDto.ToList().Any(d => d.Id == x.Id)).ToList();
        if (empCoincidentes.Count != dto.EmprendimientosDto.Count)
        {
            return new ResponseDto
            {
                Message = "Fatal error: Uno de los emprendimientos seleccionados no existen",
                IsSuccess = false
            };
        }

        var premiacion = new Premiacion
        {
            Nombre = dto.Nombre,
            Observacion = dto.Observaciones,
            FechaInicioPremiacion = dto.FechaInicioPremiacion,
            FechaFinPremiacion = dto.FechaFinPremiacion
        };
        
        var emprendimientoPremiacion = new List<EmprendimientoPremiacion>();
        empCoincidentes.ForEach(e =>
        {
            emprendimientoPremiacion.Add(new EmprendimientoPremiacion
            {
                IdEmprendimiento = e.Id,
            });
        });
        
        premiacion.Emprendimientos = emprendimientoPremiacion;
        await repository.CreateAsync(premiacion);
        return new ResponseDto
        {
            IsSuccess = true,
            Message = "Premiacion creada correctamente",
            Data = premiacion
        };

    }
}