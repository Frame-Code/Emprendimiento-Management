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
    /// <summary>
    /// Implementación de autenticación basada en comparación de contraseña en texto plano.
    /// </summary>
    public class LogInServiceImpl(IUsuarioRepository usuarioRepository) : ILogInService
    {
        /// <inheritdoc />
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

        /// <summary>
        /// Valida credenciales realizando comparación no sensible a mayúsculas/minúsculas.
        /// Nota: utiliza contraseña en texto plano; no apto para producción sin hashing.
        /// </summary>
        /// <inheritdoc />
        public async Task<bool> Validate(string username, string plainPassword)
        {
            //SOLO REVISA CONTRASEÑA PLANA, NO HASHEADA
            var user = await usuarioRepository.GetByUserName(username);
            if (user == null) return false;

            return user.Contrasenia.Trim().ToLowerInvariant() == plainPassword.Trim().ToLowerInvariant();
        }
    }
}
