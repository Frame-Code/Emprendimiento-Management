using Modelo.Properties;
using Servicios.Interfaces;
using Shared;

namespace Controller;

public class MenuOpcionesController(IMenuOpcionesService menuOpcionesService)
{
    public async Task<List<MenuOpciones>> ListarPorGrupo(string grupo, string rolCode) =>
        await menuOpcionesService.ListarPorGrupo(grupo, rolCode);

    public async Task<List<MenuOptionsDto>> ListarPorRol(string rolCode) =>
        await menuOpcionesService.ListarPorRol(rolCode);

    public async Task<ResponseDto> MenuOptionsHandler(string menuCode)
    {
        throw new Exception();
    }
}