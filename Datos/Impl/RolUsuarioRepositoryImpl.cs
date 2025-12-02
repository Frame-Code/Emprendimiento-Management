using Datos.Interfaces;
using Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Impl
{
    public class RolUsuarioRepositoryImpl(AppContext context) : IRolUsuarioRepository
    {
        public async Task CreateAsync(RolUsuario entity)
        {
            await context.RolUsuarios.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RolUsuario>> ListarAsync() =>
            await context.RolUsuarios.ToListAsync();

        public async Task<RolUsuario?> ObtenerPorIdAsync(int id) =>
            await context.RolUsuarios.FirstOrDefaultAsync(e => e.Id == id);

    }
}
