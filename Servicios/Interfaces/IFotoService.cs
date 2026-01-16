using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface IFotoService
    {
        Task<List<FotoDto>> ListarFotosAsync(); // Asegúrate de tener también un FotoDto
        Task<ResponseDto> GuardarComentarioAsync(ComentarioDto comentario);
    }
}