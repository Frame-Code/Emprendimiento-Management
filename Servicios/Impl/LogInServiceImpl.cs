using Datos.Interfaces;
using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Impl
{
    public class LogInServiceImpl(IUsuarioRepository usuarioRepository) : ILogInService
    {
        public async Task<LoginUserDto> GetUserByUsername(string username)
        {
            var user = await usuarioRepository.GetByUserName(username);
            if (user == null)
                throw new Exception("Usuario no encontrado");

            return new LoginUserDto
            {
                Username = user.NombreUsuario,
                
                RoleCode = user.RolUsuario?.Codigo ?? ""
            };
        }

        public async Task<bool> Validate(string username, string plainPassword)
        {
            //SOLO REVISA CONTRASEÑA PLANA, NO HASHEADA
            var user = await usuarioRepository.GetByUserName(username);
            if (user == null) return false;

            return user.Contrasenia.Trim().ToLowerInvariant() == plainPassword.Trim().ToLowerInvariant();
        }
    }
}
