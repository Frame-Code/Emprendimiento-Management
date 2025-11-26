using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Emprendimiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? LogoPath { get; set; }

        public int IdFacultad { get; set; }
        public Facultad Facultad { get; set; } = null!;

        public int IdRubroEmprendimiento { get; set; }
        public RubroEmprendimiento RubroEmprendimiento { get; set; } = null!;

       
    }
}
