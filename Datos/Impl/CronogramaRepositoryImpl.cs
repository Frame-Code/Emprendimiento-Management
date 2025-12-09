using Datos;
using Datos.Interfaces;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Datos.Impl
{
    public class CronogramaRepositoryImpl(AppContext context) : ICronogramaRepository
    {
        public async Task CreateAsync(Cronograma entity)
        {
            await context.Cronogramas.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var cronograma = await ObtenerPorIdAsync(id);
            if (cronograma == null)
                throw new Exception("No se encontró el id del cronograma a eliminar");

            context.Cronogramas.Remove(cronograma);
            await context.SaveChangesAsync();
        }

        public async Task<List<Cronograma>> ListarAsync() =>
            await context.Cronogramas.ToListAsync();

        public async Task<Cronograma?> ObtenerPorIdAsync(int id) =>
            await context.Cronogramas.FirstOrDefaultAsync(c => c.Id == id);
    }
}
