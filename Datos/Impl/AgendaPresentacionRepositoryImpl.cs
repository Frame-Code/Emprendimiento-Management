using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos.Interfaces;

namespace Datos.Impl
{
    internal class AgendaPresentacionRepositoryImpl(AppContext context) : IAgendaPresentacionRepository
    {
        public async Task<AgendaPresentacion?> ObtenerPorIdAsync(int id) =>
            await context.AgendaPresentaciones
                .Include(a => a.Evento)
                .Include(a => a.Emprendimiento)
                .FirstOrDefaultAsync(a => a.Id == id);

        public async Task<List<AgendaPresentacion>> ListarAsync() =>
            await context.AgendaPresentaciones
                         .Include(a => a.Evento)
                         .Include(a => a.Emprendimiento)
                         .ToListAsync();
    }
}