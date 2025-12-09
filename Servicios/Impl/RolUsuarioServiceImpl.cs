using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Impl
{
    public class RolUsuarioServiceImpl(IRolUsuarioRepository repository) : IRolUsuarioService
    {
        public async Task<RolUsuario?> GetRolByCode(string code) =>
            await repository.GetRolByCode(code);
    }
}
