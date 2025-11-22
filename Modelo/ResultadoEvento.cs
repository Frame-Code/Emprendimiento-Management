using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ResultadoEvento
    {
        public int Id { get; set; }
        public int Puesto { get; set; }
        public string? Descripcion { get; set; }
        public int IdEmprendimiento { get; set; }
        public Emprendimiento Emprendimiento { get; set; } = null!;
        public int IdCategoriaPremio { get; set; }
        public CategoriaPremio CategoriaPremio { get; set; } = null!;

    }
}
