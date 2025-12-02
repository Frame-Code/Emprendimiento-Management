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
    public class ComentarioRepositoryImpl(AppContext context) : IComentarioRepository
    {
        public async Task CreateAsync(Comentario entity)
        {
            await context.Comentarios.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Comentario>> ListarAsync() =>
            await context.Comentarios
                         .Include(c => c.Usuario)
                         .Include(c => c.Emprendimiento)
                         .ToListAsync();

        public async Task<Comentario?> ObtenerPorIdAsync(int id) =>
            await context.Comentarios
                         .Include(c => c.Usuario)
                         .Include(c => c.Emprendimiento)
                         .FirstOrDefaultAsync(c => c.Id == id);
    }
}