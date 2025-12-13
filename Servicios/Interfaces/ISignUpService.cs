using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface ISignUpService
    {
        Task<ResponseDto> RegisterUser(string username, string plainPassword, string roleCode);
        Task<bool> IsAvailableUsername(string username);

    }
}
