using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos.Interfaces;

namespace Datos.Impl
{
    public class AgendaPresentacionRepositoryImpl(AppContext context) : IAgendaPresentacionRepository
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

        public async Task CreateAsync(AgendaPresentacion entity)
        {
            await context.AgendaPresentaciones.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}