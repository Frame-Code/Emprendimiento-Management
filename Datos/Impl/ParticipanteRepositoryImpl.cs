using Datos;
using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Datos.Impl
{
    public class ParticipanteRepositoryImpl(AppContext context) : IParticipanteRepository
    {
        public async Task<Participante?> ObtenerPorIdAsync(int id) =>
            await context.Participantes
                .Include(p => p.emprendimiento)
                .Include(p => p.cargoParticipante)
                .FirstOrDefaultAsync(p => p.Id == id);

        public async Task<List<Participante>> ListarAsync() =>
            await context.Participantes
                         .Include(p => p.emprendimiento)
                         .Include(p => p.cargoParticipante)
                         .ToListAsync();

        public async Task CreateAsync(Participante entity)
        {
            await context.Participantes.AddAsync(entity);
            await context.SaveChangesAsync();
        }
            
    }
}