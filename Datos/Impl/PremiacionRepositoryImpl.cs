using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Datos.Impl;

public class PremiacionRepositoryImpl(AppContext context) : IPremiacionRepository
{
    public async Task<Premiacion?> ObtenerPorIdAsync(int id) =>
        await context.Premiacion
            .Include(x => x.Votos)
                .ThenInclude(p => p.Emprendimiento)
                .ThenInclude(p => p.Facultad)
            .Include(x => x.Votos)
                .ThenInclude(p => p.Emprendimiento)
                .ThenInclude(p => p.RubroEmprendimiento)
            .Include(x => x.Votos)
                .ThenInclude(p => p.Emprendimiento)
            .Include(x => x.Votos)
                .ThenInclude(p => p.Usuario)
            .Include(x => x.Votos)
                .ThenInclude(p => p.Usuario.RolUsuario)
            .Include(x => x.Emprendimientos)
                .ThenInclude(p => p.Emprendimiento)
                .ThenInclude(p => p.Facultad)
            .Include(x => x.Emprendimientos)
                .ThenInclude(p => p.Emprendimiento)
                .ThenInclude(p => p.RubroEmprendimiento)
            .FirstOrDefaultAsync(x => x.Id == id);

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

    public async Task UpdatePremiacion(Premiacion premiacion)
    {
        context.Premiacion.Update(premiacion);
        await context.SaveChangesAsync();
    }

    public async Task<Premiacion?> ObtenerPremiacionDisponible()
    {
        return await context.Premiacion
            .Include(x => x.Votos)
            .ThenInclude(p => p.Emprendimiento)
            .ThenInclude(p => p.Facultad)
            .Include(x => x.Votos)
            .ThenInclude(p => p.Emprendimiento)
            .ThenInclude(p => p.RubroEmprendimiento)
            .Include(x => x.Votos)
            .ThenInclude(p => p.Emprendimiento)
            .Include(x => x.Votos)
            .ThenInclude(p => p.Usuario)
            .Include(x => x.Votos)
            .ThenInclude(p => p.Usuario.RolUsuario)
            .Include(x => x.Emprendimientos)
            .ThenInclude(p => p.Emprendimiento)
            .ThenInclude(p => p.Facultad)
            .Include(x => x.Emprendimientos)
            .ThenInclude(p => p.Emprendimiento)
            .ThenInclude(p => p.RubroEmprendimiento)
            .FirstOrDefaultAsync(p => p.FechaInicioPremiacion <= DateTime.Now && p.FechaFinPremiacion > DateTime.Now);
    }
}