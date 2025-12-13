using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class VerParticipantesDto
    {
        public string Nombre { get; set; } = null!;
        public string? Apellido { get; set; } = null;
        public string Telefono { get; set; } = null!;
        public string Identificacion { get; set; } = null!;

    }
}

