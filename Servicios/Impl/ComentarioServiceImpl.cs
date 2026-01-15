using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl;

public class ComentarioServiceImpl(
    IComentarioRepository repository,
    IEmprendimientoRepository emprendimientoRepository,
    IUsuarioRepository usuarioRepository) 
    : IComentarioService
{
    public async Task<ResponseDto> Save(Comentario comentario)
    {

        var emprendimiento = await emprendimientoRepository.ObtenerPorIdAsync(comentario.IdEmprendimiento);
        if (emprendimiento is null)
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "No se ha encontrado el emprendimiento seleccionado"
            };

        var usuario = await usuarioRepository.ObtenerPorIdAsync(comentario.IdUsuario);
        if (usuario is null)
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "Fatal error, no se encontró el usuario logeado"
            };

        await repository.CreateAsync(comentario);
        return new ResponseDto
        {
            IsSuccess = true,
            Message = "Comentario creado correctamente"
        };

    }

    public async Task<ResponseDto> Save(string content, string username, int idEmprendimiento)
    {
        var emprendimiento = await emprendimientoRepository.ObtenerPorIdAsync(idEmprendimiento);
        if (emprendimiento is null)
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "No se ha encontrado el emprendimiento seleccionado"
            };
        
        var usuario = await usuarioRepository.GetByUserName(username);
        if (usuario is null)
            return new ResponseDto
            {
                IsSuccess = false,
                Message = "Fatal error, no se encontró el usuario logeado"
            };

        var comentario = new Comentario
        {
            IdEmprendimiento = idEmprendimiento,
            HoraCreacion = DateTime.Now,
            IdUsuario = usuario.Id,
            Texto = content
        };

        await repository.CreateAsync(comentario);
        return new ResponseDto
        {
            IsSuccess = true,
            Message = "Comentario creado correctamente"
        };
    }
}