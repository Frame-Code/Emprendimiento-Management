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
    internal class EmprendimientoRepositoryImpl(AppContext context) : IEmprendimientoRepository
    {
        public async Task<List<Emprendimiento>> ListarAsync() => 
            await context.Emprendimientos.ToListAsync();

        public async Task<Emprendimiento?> ObtenerPorIdAsync(int id) =>
            await context.Emprendimientos.FirstOrDefaultAsync(e => e.Id == id);
    }
}
