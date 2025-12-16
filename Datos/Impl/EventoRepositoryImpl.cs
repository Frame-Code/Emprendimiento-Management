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
    public class EventoRepositoryImpl : IEventoRepository
    {
        private readonly AppContext _context;

        public EventoRepositoryImpl(AppContext context)
        {
            _context = context;
        }

        // Crear evento
        public async Task CreateAsync(Evento entity)
        {
            await _context.Eventos.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        // Eliminar evento por Id
        public async Task DeleteByIdAsync(int id)
        {
            var evento = await ObtenerPorIdAsync(id);
            if (evento == null)
                throw new Exception("Evento no encontrado");

            _context.Eventos.Remove(evento);
            await _context.SaveChangesAsync();
        }

        // Listar todos los eventos
        public async Task<List<Evento>> ListarAsync()
        {
            return await _context.Eventos
                .OrderBy(e => e.FechaInicio)
                .ToListAsync();
        }

        // Obtener evento por Id
        public async Task<Evento?> ObtenerPorIdAsync(int id)
        {
            return await _context.Eventos
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}