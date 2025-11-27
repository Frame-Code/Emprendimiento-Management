using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Impl
{
    internal class ComentarioRepositoryImpl(AppContext context) : IComentarioRepository
    {
        public async Task<List<Comentario>> ListarAsync() =>
            await context.Comentarios
            .Include(c => c.Usuario)
            .Include(c => c.Emprendimiento)
            .ToListAsync();

        public async Task<Comentario?> ObtenerComentarioAsync(int id) =>
            await context.Comentarios
            .Include(c => c.Usuario)
            .Include(c => c.Emprendimiento)
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}
