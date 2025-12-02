using Microsoft.EntityFrameworkCore;
using Modelo;
using Datos.Interfaces;

namespace Datos.Impl
{
    public class CargoParticipanteRepositoryImpl(AppContext context) : ICargoParticipanteRepository
    {
        public async Task<CargoParticipante?> ObtenerPorIdAsync(int id) =>
            await context.CargosParticipante
                .FirstOrDefaultAsync(c => c.Id == id);

        public async Task<List<CargoParticipante>> ListarAsync() =>
            await context.CargosParticipante
                         .ToListAsync();

        public async Task CreateAsync(CargoParticipante entity)
        {
            await context.CargosParticipante.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}