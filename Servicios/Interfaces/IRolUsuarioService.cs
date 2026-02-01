using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Servicio para consulta de roles de usuario.
    /// </summary>
    public interface IRolUsuarioService
    {
        /// <summary>Obtiene un rol por su código.</summary>
        public Task<RolUsuario?> GetRolByCode(string code);
    }
}
