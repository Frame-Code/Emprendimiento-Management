using Datos;
using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Datos.Impl
{
    internal class ResultadoEventoRepositoryImpl(AppContext context) : IResultadoEventoRepository
    {
        public async Task<ResultadoEvento?> ObtenerPorIdAsync(int id) =>
            await context.ResultadoEventos
                .Include(r => r.Emprendimiento)
                .Include(r => r.CategoriaPremio)
                .FirstOrDefaultAsync(r => r.Id == id);

        public async Task<List<ResultadoEvento>> ListarAsync() =>
            await context.ResultadoEventos
                         .Include(r => r.Emprendimiento)
                         .Include(r => r.CategoriaPremio)
                         .ToListAsync();

        public async Task CreateAsync(ResultadoEvento entity) =>
            await context.ResultadoEventos.AddAsync(entity);
    }
}