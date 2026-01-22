using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ComentarioDto
    {
        
        public string Texto { get; set; } = null!; 
        public DateTime HoraCreacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmprendimiento { get; set; }
        public string UsuarioNombre { get; set; } = null!;
        public string Facultad { get; set; } = null!;
        public string RubroNombre { get; set; } = null!;
        public string NombreEmprendimiento { get; set; } = null!;
    }
}