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
    internal class RolUsuarioImpl(AppContext context) : IRolUsuarioRepository
    {
        public async Task<List<RolUsuario>> ListarAsync() =>
            await context.RolUsuarios.ToListAsync();

        public async Task<RolUsuario?> ObtenerPorIdAsync(int id) =>
            await context.RolUsuarios.FirstOrDefaultAsync(e => e.Id == id);

    }
}
