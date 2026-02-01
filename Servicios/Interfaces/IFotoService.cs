using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Servicio para consulta de fotos y comentarios relacionados a emprendimientos.
    /// </summary>
    public interface IFotoService
    {
        /// <summary>Lista fotos asociadas a un emprendimiento.</summary>
        Task<List<FotoDto>> ListarFotosPorEmprendimientoAsync(int idEmprendimiento); 

        /// <summary>Guarda un comentario relacionado con un emprendimiento.</summary>
        Task<ResponseDto> GuardarComentarioAsync(ComentarioDto comentario);
    }
}
