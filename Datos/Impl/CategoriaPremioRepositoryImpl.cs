using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos.Interfaces;

namespace Datos.Impl
{
    public class CategoriaPremioRepositoryImpl(AppContext context) : ICategoriaPremioRepository
    {
        public async Task<CategoriaPremio?> ObtenerPorIdAsync(int id) =>
            await context.CategoriasPremio
                .FirstOrDefaultAsync(c => c.Id == id);

        public async Task<List<CategoriaPremio>> ListarAsync() =>
            await context.CategoriasPremio
                         .ToListAsync();

        public async Task CreateAsync(CategoriaPremio entity)
        {
            await context.CategoriasPremio.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}