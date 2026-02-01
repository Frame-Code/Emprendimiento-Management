using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

/// <summary>
/// Implementación del servicio de comentarios: creación y consulta por emprendimiento.
/// </summary>
public class ComentarioServiceImpl(
    IComentarioRepository repository,
    IUsuarioRepository usuarioRepository,
    Datos.AppContext db)
    : IComentarioService
{
    /// <inheritdoc />
    public async Task<ResponseDto> Save(Comentario comentario)
    {
        await repository.CreateAsync(comentario);
        return new ResponseDto { IsSuccess = true, Message = "Comentario creado" };
    }

    /// <inheritdoc />
    public async Task<ResponseDto> Save(string content, string username, int idEmprendimiento)
    {
        var usuario = await usuarioRepository.GetByUserName(username);
        if (usuario is null)
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "Fatal error: Usuario no encontrado"
            };
            
        var comentario = new Comentario
        {
            IdEmprendimiento = idEmprendimiento,
            HoraCreacion = DateTime.Now,
            IdUsuario = usuario.Id,
            Texto = content
        };
        await repository.CreateAsync(comentario);
        return new ResponseDto { IsSuccess = true };
    }

    /// <inheritdoc />
    public async Task<List<ComentarioDto>> ListarComentariosAsync(int idEmprendimiento)
    {
        return await db.Comentarios
            .AsNoTracking()
            .Include(c => c.Usuario)
            .Include(c => c.Emprendimiento)
                .ThenInclude(e => e.Facultad) 
            .Include(c => c.Emprendimiento)
                .ThenInclude(e => e.RubroEmprendimiento) 
            .Where(c => c.IdEmprendimiento == idEmprendimiento)
            .Select(c => new ComentarioDto
            {
                Texto = c.Texto,
                UsuarioNombre = c.Usuario.NombreUsuario,
                HoraCreacion = c.HoraCreacion,
                Facultad = c.Emprendimiento.Facultad.Nombre,
                RubroNombre = c.Emprendimiento.RubroEmprendimiento.Nombre,
                NombreEmprendimiento = c.Emprendimiento.Nombre
            })
            .ToListAsync();
    }
}
