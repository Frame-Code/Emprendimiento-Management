using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ComentarioDto
    {
        public int IdEmprendimiento { get; set; }
        public string Texto { get; set; }
        public DateTime HoraCreacion { get; set; }
        public int IdUsuario { get; set; } 
    }
}