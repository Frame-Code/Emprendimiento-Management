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

        public async Task DeleteByIdAsync(int id)
        {
            var emprendimiento = await ObtenerPorIdAsync(id);
            if (emprendimiento == null)
                throw new Exception("No se encontro el id del emprendimiento a eliminar");
            
            context.Emprendimientos.Remove(emprendimiento);
            context.SaveChanges();
            return;
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
