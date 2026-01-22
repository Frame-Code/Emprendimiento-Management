using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

public class ComentarioServiceImpl(
    IComentarioRepository repository,
    IEmprendimientoRepository emprendimientoRepository,
    IUsuarioRepository usuarioRepository,
    Datos.AppContext db)
    : IComentarioService
{
    public async Task<ResponseDto> Save(Comentario comentario)
    {
        await repository.CreateAsync(comentario);
        return new ResponseDto { IsSuccess = true, Message = "Comentario creado" };
    }

    public async Task<ResponseDto> Save(string content, string username, int idEmprendimiento)
    {
        var usuario = await usuarioRepository.GetByUserName(username);
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
                UsuarioNombre = c.Usuario != null ? c.Usuario.NombreUsuario : "Anónimo",
                HoraCreacion = c.HoraCreacion,

                Facultad = c.Emprendimiento.Facultad != null ? c.Emprendimiento.Facultad.Nombre : "N/A",
                RubroNombre = c.Emprendimiento.RubroEmprendimiento != null ? c.Emprendimiento.RubroEmprendimiento.Nombre : "N/A",
                NombreEmprendimiento = c.Emprendimiento != null ? c.Emprendimiento.Nombre : "N/A"
            })
            .ToListAsync();
    }
}