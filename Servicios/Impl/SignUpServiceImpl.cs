using Datos.Interfaces;
using Modelo;
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
    /// Implementación del servicio de registro de usuarios.
    /// </summary>
    public class SignUpServiceImpl(
        IUsuarioRepository usuarioRepository, 
        IRolUsuarioRepository rolUsuarioRepository) : ISignUpService
    {
        /// <inheritdoc />
        public async Task<bool> IsAvailableUsername(string username)
        {
            var allUsers = await usuarioRepository.ListarAsync();
            return !allUsers.Any(user => 
                string.Equals(user.NombreUsuario, username.Trim(), StringComparison.CurrentCultureIgnoreCase));
        }

        /// <inheritdoc />
        public async Task<ResponseDto> RegisterUser(string username, string plainPassword, string roleCode)
        {
            var rol = await rolUsuarioRepository.GetRolByCode(roleCode);
            if(rol == null)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "El rol especificado no existe."
                };
            }

            var usuarioDisponible = await IsAvailableUsername(username);
            if (!usuarioDisponible)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = "El nombre de usuario ya está en uso."
                };
            }

            var usuario = new Usuario
            {
                NombreUsuario = username.Trim(),
                Contrasenia = plainPassword,
                IdRolUsuario = rol.Id
            };
            
            await usuarioRepository.CreateAsync(usuario);
            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Usuario registrado exitosamente.",
                Data = usuario
            };
        }
    }
}
