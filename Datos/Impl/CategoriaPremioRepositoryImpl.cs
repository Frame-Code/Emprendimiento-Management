using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos.Interfaces;

namespace Datos.Impl
{
    internal class CategoriaPremioRepositoryImpl(AppContext context) : ICategoriaPremioRepository
    {
        public async Task<CategoriaPremio?> ObtenerPorIdAsync(int id) =>
            await context.CategoriasPremio
                .FirstOrDefaultAsync(c => c.Id == id);

        public async Task<List<CategoriaPremio>> ListarAsync() =>
            await context.CategoriasPremio
                         .ToListAsync();
        
    }
}