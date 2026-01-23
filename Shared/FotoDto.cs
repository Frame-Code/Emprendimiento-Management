using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class FotoDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int EmprendimientoId { get; set; }

        
    }
}
