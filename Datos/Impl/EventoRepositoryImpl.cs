using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Impl
{
    public class EventoRepositoryImpl(AppContext context) : IEventoRepository
    {
        public async Task CreateAsync(Evento entity)
        {
            await context.Eventos.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Evento>> ListarAsync() =>
            await context.Eventos.ToListAsync();

        public async Task<Evento?> ObtenerPorIdAsync(int id) =>
            await context.Eventos.FirstOrDefaultAsync(e => e.Id == id);
    }
}