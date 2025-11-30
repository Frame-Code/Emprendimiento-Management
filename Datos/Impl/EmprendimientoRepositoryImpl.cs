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
    public class EmprendimientoRepositoryImpl(AppContext context) : IEmprendimientoRepository
    {
        public async Task CreateAsync(Emprendimiento entity)
        {
            await context.Emprendimientos.AddAsync(entity);
            await context.SaveChangesAsync();
        }
            

        public async Task<List<Emprendimiento>> ListarAsync() => 
            await context.Emprendimientos
            .Include(e => e.Facultad)
            .Include(e => e.RubroEmprendimiento)
            .ToListAsync();

        public async Task<Emprendimiento?> ObtenerPorIdAsync(int id) =>
            await context.Emprendimientos.FirstOrDefaultAsync(e => e.Id == id);
    }
}
