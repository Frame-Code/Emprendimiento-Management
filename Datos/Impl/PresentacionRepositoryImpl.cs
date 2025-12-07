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
    public class PresentacionRepositoryImpl(AppContext context) : IPresentacionRepository
    {
        public async Task CreateAsync(Presentacion entity)
        {
            await context.Presentaciones.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var presentacion = await ObtenerPorIdAsync(id);
            if (presentacion == null)
                throw new Exception("No se encontró el id de la presentación a eliminar");

            context.Presentaciones.Remove(presentacion);
            await context.SaveChangesAsync();
        }

        public async Task<List<Presentacion>> ListarAsync() =>
            await context.Presentaciones.ToListAsync();

        public async Task<Presentacion?> ObtenerPorIdAsync(int id) =>
            await context.Presentaciones.FirstOrDefaultAsync(p => p.Id == id);
    }
}

