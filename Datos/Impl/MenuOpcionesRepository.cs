using Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using Modelo.Properties;

namespace Datos.Impl;

public class MenuOpcionesRepository(AppContext context) : IMenuOpcionesRepository
{
    public async Task<MenuOpciones?> ObtenerPorIdAsync(int id) =>
        await context.MenuOpciones.FirstOrDefaultAsync(menu => menu.Id == id);

    public async Task<List<MenuOpciones>> ListarAsync() =>
        await context.MenuOpciones.ToListAsync();

    public async Task CreateAsync(MenuOpciones entity)
    {
        await context.MenuOpciones.AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public Task DeleteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<MenuOpciones>> ListarPorGrupo(string grupo, string rolCode) =>
        await context.MenuOpciones
            .Where(menu => menu.RolUsuario.Codigo == rolCode && menu.Grupo == grupo)
            .ToListAsync();

    public async Task<List<MenuOpciones>> ListarPorRol(string rolCode) =>
        await context.MenuOpciones
            .Where(menu => menu.RolUsuario.Codigo == rolCode)
            .ToListAsync();
}