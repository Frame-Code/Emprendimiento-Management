using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ParticipanteDto
    {
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;  
        public string NoIdentificacion { get; set; } = null!;   
        public string NoTelefono { get; set; } = null!;
        public int IdEmprendimiento { get; set; }
        public int IdCargoParticipante { get; set; }

        public List<FileDto> fotos { get; set; }
    }
}
