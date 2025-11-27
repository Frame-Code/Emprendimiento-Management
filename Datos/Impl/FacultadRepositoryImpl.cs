using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Datos.Impl
{
    internal class FacultadRepositoryImpl(AppContext context) : IFacultadRepository
    {
        public async Task<Facultad?> ObtenerPorIdAsync(int id)  =>
            await context.Facultades
                .FirstOrDefaultAsync(f => f.Id == id);

        public async Task<List<Facultad>> ListarAsync() =>
            await context.Facultades
                         .ToListAsync();

    }
}
