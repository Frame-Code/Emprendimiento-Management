using Datos;
using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Datos.Impl
{
    public class ParticipanteRepositoryImpl : IParticipanteRepository
    {
        private readonly AppContext context;

        public ParticipanteRepositoryImpl(AppContext context)
        {
            this.context = context;
        }

        public ParticipanteRepositoryImpl()
        {
        }

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

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}