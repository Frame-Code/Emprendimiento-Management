using Datos;
using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Datos
{
    internal class FacultadRepositoryImpl(AppContext context) : IFacultadRepository
    {
        public async Task<List<Facultad>> ListarAsync() =>
            await context.Facultades
                         .ToListAsync();

        public async Task<Facultad?> ObtenerFacultadAsync(int id) =>
            await context.Facultades
                         .FirstOrDefaultAsync(f => f.Id == id);
    }
}
