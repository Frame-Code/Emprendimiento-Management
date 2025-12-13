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
    public class UsuarioRepositoryImpl(AppContext context) : IUsuarioRepository
    {
        public async Task CreateAsync(Usuario entity)
        {
            await context.Usuarios.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Usuario?> GetByUserName(string userName) =>
            await context.Usuarios
            .Include(u => u.RolUsuario)
            .FirstOrDefaultAsync(usr => usr.NombreUsuario == userName);

        public async Task<List<Usuario>> ListarAsync() =>
            await context.Usuarios.
            Include(u => u.RolUsuario)
            .ToListAsync();

        public async Task<Usuario?> ObtenerPorIdAsync(int id) =>
            await context.Usuarios
            .Include(u => u.RolUsuario)
            .FirstOrDefaultAsync(u => u.Id == id);
    }
}