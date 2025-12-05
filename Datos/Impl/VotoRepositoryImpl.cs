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
    public class VotoRepositoryImpl(AppContext context) : IVotoRepository
    {
        public async Task CreateAsync(Voto entity)
        {
            await context.Votos.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Voto>> ListarAsync() =>
            await context.Votos.ToListAsync();

        public async Task<Voto?> ObtenerPorIdAsync(int id) =>
            await context.Votos.FirstOrDefaultAsync(v => v.Id == id);
    }
}
