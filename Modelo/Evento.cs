using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? Ubicacion { get; set; }


        // ⭐ Constructor principal
        public Evento(string nombre, string? descripcion, DateTime inicio, DateTime fin, string? ubicacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaInicio = inicio;
            FechaFin = fin;
            Ubicacion = ubicacion;
        }

        // ⭐ Método 1: Validar si el evento es válido (fecha inicio < fecha fin)
        public bool EsValido()
        {
            return FechaInicio < FechaFin;
        }

        // ⭐ Método 2: Saber si el evento está ocurriendo ahora
        public bool EstaEnCurso()
        {
            DateTime hoy = DateTime.Now;
            return hoy >= FechaInicio && hoy <= FechaFin;
        }

        // ⭐ Método 3: Cambiar fecha del evento
        public void ActualizarFechas(DateTime nuevaInicio, DateTime nuevaFin)
        {
            FechaInicio = nuevaInicio;
            FechaFin = nuevaFin;
        }

        // ⭐ Método 4: Mostrar información del evento
        public string MostrarInfo()
        {
            return
                $" Evento: {Nombre}\n" +
                $" Descripción: {Descripcion}\n" +
                $" Ubicación: {Ubicacion}\n" +
                $" Inicio: {FechaInicio}\n" +
                $" Fin: {FechaFin}";
        }
    }
}
