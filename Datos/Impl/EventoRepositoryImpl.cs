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
    internal class EventoRepositoryImpl(AppContext context) : IEventoRepository
    {
        public async Task<List<Evento>> ListarAsync() =>
            await context.Eventos
                         .ToListAsync();

        public async Task<Evento?> ObtenerPorIdAsync(int id) =>
            await context.Eventos
                         .FirstOrDefaultAsync(e => e.Id == id);
    }
}