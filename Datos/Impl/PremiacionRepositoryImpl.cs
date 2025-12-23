using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Datos.Impl;

public class PremiacionRepositoryImpl(AppContext context) : IPremiacionRepository
{
    public async Task<Premiacion?> ObtenerPorIdAsync(int id) =>
        await context.Premiacion.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<List<Premiacion>> ListarAsync() =>
        await context.Premiacion.ToListAsync();

    public async Task CreateAsync(Premiacion entity)
    {
        await context.Premiacion.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public Task DeleteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}