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
            .Where(c => c.IdEmprendimiento == idEmprendimiento)
            .Select(c => new ComentarioDto
            {
                Texto = c.Texto,
                UsuarioNombre = c.Usuario.NombreUsuario,
                HoraCreacion = c.HoraCreacion,
                Facultad = c.Emprendimiento.Facultad.Nombre,
                RubroNombre = c.Emprendimiento.RubroEmprendimiento.Nombre,

                // MAPEAMOS EL NOMBRE DEL NEGOCIO AQUÍ
                NombreEmprendimiento = c.Emprendimiento.Nombre
            })
            .ToListAsync();
    }
}