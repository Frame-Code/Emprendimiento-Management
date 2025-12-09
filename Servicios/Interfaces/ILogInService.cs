using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface ILogInService
    {
        Task<bool> Validate(string username, string plainPassword);
        Task<LoginUserDto> GetUserByUsername(string username);
    }
}
