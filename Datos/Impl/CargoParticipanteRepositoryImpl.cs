using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos;

namespace Datos
{
    internal class CargoParticipanteRepositoryImpl(AppContext context) : ICargoParticipanteRepository
    {
        public async Task<List<CargoParticipante>> ListarAsync() =>
            await context.CargosParticipante
                         .ToListAsync();

        public async Task<CargoParticipante?> ObtenerCargoParticipanteAsync(int id) =>
            await context.CargosParticipante
                         .FirstOrDefaultAsync(c => c.Id == id);
    }
}