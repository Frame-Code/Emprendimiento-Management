using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IRepository<T>
    {
        Task<T?> ObtenerPorIdAsync(int id);
        Task<List<T>> ListarAsync();
        Task CreateAsync(T entity);
    }
}
