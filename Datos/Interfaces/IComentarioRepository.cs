using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IComentarioRepository
    {
        Task<List<Comentario>> ListarAsync();
        Task<Comentario?> ObtenerComentarioAsync(int id);
    }
}
