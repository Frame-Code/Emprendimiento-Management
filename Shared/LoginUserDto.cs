using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class LoginUserDto
    {
        public string Username { get; init; } = null!;
        public string RoleCode { get; init; } = null!;
    }
}
