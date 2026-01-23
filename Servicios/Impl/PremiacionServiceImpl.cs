using Datos.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Modelo;
using Servicios.Interfaces;
using Servicios.Reports;
using Shared;

namespace Servicios.Impl;

public class PremiacionServiceImpl(
    IPremiacionRepository repository, 
    IEmprendimientoRepository emprendimientoRepository,
    IUsuarioRepository usuarioRepository,
    IPdfReportGenerator reportGenerator,
    IServiceProvider serviceProvider
    ) : IPremiacionService
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


    public async Task<ResponseDto> GenerateReport(string reportName, TypeReport typeReport, int idPremiacion)
    {
        var premiacion = await ObtenerPremiacionPorIdAsync(idPremiacion);
        if (premiacion == null)
        {
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "No se ha encontrado la premiacion seleccionada"
            };
        }

        try
        {
            using var scope = serviceProvider.CreateScope();
            var report = scope.ServiceProvider.GetServices<IReport>()
                .FirstOrDefault(x => x.Report == typeReport);
            if (report == null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "No se ha encontrado el tipo de reporte generado"
                };
            }

            
            await reportGenerator.Generate(report, (object)premiacion, reportName);
            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Reporte generado correctamente",
                Data = reportName
            };
        }
        catch (Exception e)
        {
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "Se ha producido un error al generar el reporte, consulte a sistemas " + e.Message 
            };
        }
        
    }



    public async Task<PremiacionDto?> ObtenerPremiacionDisponible()
    {
        var premiacion = await repository.ObtenerPremiacionDisponible();
        if (premiacion is null)
            return null;

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
                    Id = e.Emprendimiento.Id,
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
        };
    }

    public async Task<ResponseDto> Votar(int idPremiacion, int idEmprendimiento, string username)
    {
        var premiacion = await repository.ObtenerPorIdAsync(idPremiacion);
        if (premiacion is null)
            return new ResponseDto()
            {
                IsSuccess = false,
                Message = "No se ha encontrado la premiacion seleccionada"
            };

        var emprendimiento = await emprendimientoRepository.ObtenerPorIdAsync(idEmprendimiento);
        if (emprendimiento is null)
            return new ResponseDto()
            {
                IsSuccess = false,
                Message = "No se ha encontrado el emprendimiento seleccionado"
            };

        var user = await usuarioRepository.GetByUserName(username);
        if (user is null)
            return new ResponseDto()
            {
                IsSuccess = false,
                Message = "Fatal error: no se ha encontrado el usuario"
            };

        var voto = new Voto
        {
            Emprendimiento = emprendimiento,
            FechaCreacion = DateTime.Now,
            IdEmprendimiento = idEmprendimiento,
            IdUsuario = user.Id
        };
        
        premiacion.Votos.Add(
            new VotoPremiacion
            {
                FechaCreacion = DateTime.Now,
                IdPremiacion = idPremiacion,
                Premiacion = premiacion,
                Voto = voto
            });

        await repository.UpdatePremiacion(premiacion);
        return new ResponseDto()
        {
            IsSuccess = true,
            Message = "Voto registrado correctamente"
        };
    }

}