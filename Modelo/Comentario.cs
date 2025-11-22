using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
        public DateTime HoraCreacion { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int IdEmprendimiento { get; set; }
        public Emprendimiento Emprendimiento { get; set; } = null!;
    }
}
