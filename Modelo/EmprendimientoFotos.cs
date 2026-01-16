using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class EmprendimientoFotos
    {
        public int Id { get; set; } // Asegúrate de que solo haya UN "Id"
        public int EmprendimientosId { get; set; } // Nombre exacto de SQL
        public int FotosId { get; set; } // Nombre exacto de SQL
    }
}