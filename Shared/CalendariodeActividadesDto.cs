using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class CalendariodeActividadesDto
    {
        public string NombreEvento { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Facultad { get; set; } = null!;
        public int FacultadId { get; set; }
    }
}
