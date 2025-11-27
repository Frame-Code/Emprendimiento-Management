using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos.Interfaces;

namespace Datos.Impl
{
    internal class CargoParticipanteRepositoryImpl(AppContext context) : ICargoParticipanteRepository
    {
        public async Task<CargoParticipante?> ObtenerPorIdAsync(int id) =>
            await context.CargosParticipante
                .FirstOrDefaultAsync(c => c.Id == id);

        public async Task<List<CargoParticipante>> ListarAsync() =>
            await context.CargosParticipante
                         .ToListAsync();
    }
}