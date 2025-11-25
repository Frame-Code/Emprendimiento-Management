using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos;

namespace Datos
{
    internal class AgendaPresentacionRepositoryImpl(AppContext context) : IAgendaPresentacionRepository
    {
        public async Task<List<AgendaPresentacion>> ListarAsync() =>
            await context.AgendaPresentaciones
                         .Include(a => a.Evento)
                         .Include(a => a.Emprendimiento)
                         .ToListAsync();

        public async Task<AgendaPresentacion?> ObtenerAgendaPresentacionAsync(int id) =>
            await context.AgendaPresentaciones
                         .Include(a => a.Evento)
                         .Include(a => a.Emprendimiento)
                         .FirstOrDefaultAsync(a => a.Id == id);
    }
}