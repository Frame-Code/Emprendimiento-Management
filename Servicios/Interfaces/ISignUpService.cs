using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Servicio para registro de usuarios y validación de disponibilidad de nombre.
    /// </summary>
    public interface ISignUpService
    {
        /// <summary>Registra un nuevo usuario con rol asignado.</summary>
        Task<ResponseDto> RegisterUser(string username, string plainPassword, string roleCode);

        /// <summary>Verifica si un nombre de usuario está disponible.</summary>
        Task<bool> IsAvailableUsername(string username);
    }
}
