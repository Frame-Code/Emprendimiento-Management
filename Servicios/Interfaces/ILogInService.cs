using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Servicios de autenticación y consulta de datos de usuario.
    /// </summary>
    public interface ILogInService
    {
        /// <summary>
        /// Valida credenciales contra el repositorio de usuarios.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <param name="plainPassword">Contraseña en texto plano.</param>
        /// <returns><c>true</c> si es válido; de lo contrario, <c>false</c>.</returns>
        Task<bool> Validate(string username, string plainPassword);

        /// <summary>
        /// Obtiene datos básicos del usuario por su nombre de usuario.
        /// </summary>
        /// <param name="username">Nombre de usuario.</param>
        /// <returns>DTO con información del usuario.</returns>
        Task<LoginUserDto> GetUserByUsername(string username);
    }
}
