using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modelo
{
    public class Participante
    {
        public int Id { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string NombresCompletos
        {
            get
            {
                return $"{Nombres} {Apellidos}";
            }
        }
        public string NumeroIdentificacion { get; set; } = null!;
        public string NumeroTelefono { get; set; } = null!;
        public string? FotoPath { get; set; }
        public int? IdEmprendimiento { get; set; }
        public Emprendimiento? Emprendimiento { get; set; }
        public int IdCargoParticipante { get; set; }
        public CargoParticipante CargoParticipante { get; set; } = null!;

    }
}
