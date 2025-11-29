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
    internal class RubroEmpendimientoImpl(AppContext context) : IRubroEmprendimientoRepository
    {
        public async Task CreateAsync(RubroEmprendimiento entity) => 
            await context.RubrosEmprendimiento.AddAsync(entity);

        public async Task<List<RubroEmprendimiento>> ListarAsync() =>
            await context.RubrosEmprendimiento.ToListAsync();

        public async Task<RubroEmprendimiento?> ObtenerPorIdAsync(int id) =>
            await context.RubrosEmprendimiento.FirstOrDefaultAsync(rp => rp.Id == id);
    }
}
