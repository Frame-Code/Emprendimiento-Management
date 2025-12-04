using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Presentacion
    {
        public int Id { get; set; }
        public string Expositor { get; set; }
        public int Orden { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Ubicacion { get; set; }
    }
}
