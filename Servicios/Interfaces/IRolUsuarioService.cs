using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface IRolUsuarioService
    {
        public Task<RolUsuario?> GetRolByCode(string code);
    }
}
