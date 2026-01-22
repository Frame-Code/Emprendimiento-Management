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
        Task<List<FotoDto>> ListarFotosAsync(); 
        Task<ResponseDto> GuardarComentarioAsync(ComentarioDto comentario);
    }
}