using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos;

namespace Datos
{
    internal class CategoriaPremioRepositoryImpl(AppContext context) : ICategoriaPremioRepository
    {
        public async Task<List<CategoriaPremio>> ListarAsync() =>
            await context.CategoriasPremio
                         .ToListAsync();

        public async Task<CategoriaPremio?> ObtenerCategoriaPremioAsync(int id) =>
            await context.CategoriasPremio
                         .FirstOrDefaultAsync(c => c.Id == id);
    }
}