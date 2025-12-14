using Modelo.Properties;
using Shared;

namespace Servicios.Interfaces;

public interface IMenuOpcionesService
{
    public Task<List<MenuOpciones>> ListarPorGrupo(string grupo, string rolCode);
    public Task<List<MenuOptionsDto>> ListarPorRol(string rolCode);
}