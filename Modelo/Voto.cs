using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Voto
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdEmprendimiento { get; set; }
        public Emprendimiento Emprendimiento { get; set; } = null!;
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
    }
}
