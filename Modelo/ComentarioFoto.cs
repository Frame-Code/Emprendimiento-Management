using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ComentarioFoto
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int FotoId { get; set; }
        public Foto Foto { get; set; } = null!;
    }
}

