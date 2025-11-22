using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class AgendaPresentacion
    {
        public int Id { get; set; }
        public int IdEvento { get; set; }
        public Evento Evento { get; set; } = null!;
        public int IdEmprendimiento { get; set; }
        public Emprendimiento Emprendimiento { get; set; } = null!;
    }
}
