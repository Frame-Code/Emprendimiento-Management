using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cronograma
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; } = null!;
        public string Ubicacion { get; set; } = null!;
    }
}
