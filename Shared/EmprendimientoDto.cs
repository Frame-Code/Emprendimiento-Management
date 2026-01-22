using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class EmprendimientoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Facultad { get; set; } = null!;
        public string Rubro { get; set; } = null!;
        public List<string> ImagenesUrls { get; set; } = new List<string>();
    }
}
