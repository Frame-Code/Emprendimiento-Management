using Modelo;
using Shared;

namespace Servicios.Interfaces;

/// <summary>
/// Servicio para administración de comentarios sobre emprendimientos.
/// </summary>
public interface IComentarioService
{
    /// <summary>Guarda un comentario de texto asociado a un emprendimiento.</summary>
    Task<ResponseDto> Save(string content, string username, int idEmprendimiento);

    /// <summary>Guarda un comentario ya materializado.</summary>
    Task<ResponseDto> Save(Comentario comentario);

    /// <summary>Lista comentarios de un emprendimiento con datos enriquecidos.</summary>
    Task<List<ComentarioDto>> ListarComentariosAsync(int idEmprendimiento);
}
