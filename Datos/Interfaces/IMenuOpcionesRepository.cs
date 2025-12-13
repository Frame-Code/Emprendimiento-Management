using Modelo.Properties;

namespace Datos.Interfaces;

public interface IMenuOpcionesRepository : IRepository<MenuOpciones>
{
    public Task<List<MenuOpciones>> ListarPorGrupo(string grupo, string rolCode);
    public Task<List<MenuOpciones>> ListarPorRol(string rolCode);

}