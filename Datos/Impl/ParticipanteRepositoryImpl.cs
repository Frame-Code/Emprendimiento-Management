using Datos;
using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Datos
{
    internal class ParticipanteRepositoryImpl(AppContext context) : IParticipanteRepository
    {
        public async Task<List<Participante>> ListarAsync() =>
            await context.Participantes
                         .Include(p => p.emprendimiento)
                         .Include(p => p.cargoParticipante)
                         .ToListAsync();

        public async Task<Participante?> ObtenerParticipanteAsync(int id) =>
            await context.Participantes
                         .Include(p => p.emprendimiento)
                         .Include(p => p.cargoParticipante)
                         .FirstOrDefaultAsync(p => p.Id == id);
    }
}