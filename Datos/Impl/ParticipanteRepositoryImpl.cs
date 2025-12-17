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

        public async Task<Participante?> ObtenerPorIdAsync(int id) =>
            await context.Participantes
                .Include(p => p.Emprendimiento)
                .Include(p => p.CargoParticipante)
                .FirstOrDefaultAsync(p => p.Id == id);

        public async Task<List<Participante>> ListarAsync() =>
            await context.Participantes
                         .Include(p => p.Emprendimiento)
                         .Include(p => p.CargoParticipante)
                         .ToListAsync();

        public async Task CreateAsync(Participante entity)
        {
            await context.Participantes.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Participante entity)
        {
            context.Participantes.Update(entity);
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExisteIdentificacionAsync(string identificacion) =>
            await context.Participantes.AnyAsync(p => p.NumeroIdentificacion == identificacion);
        
        public async Task<bool> ExisteTelefonoAsync(string telefono) =>
            await context.Participantes.AnyAsync(p => p.NumeroTelefono == telefono);



    }
}