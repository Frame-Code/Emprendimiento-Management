using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Emprendimiento
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? LogoPath { get; set; }

        public int IdFacultad { get; set; }
        public Facultad Facultad { get; set; } = null!;

        public int IdRubroEmprendimiento { get; set; }
        public RubroEmprendimiento RubroEmprendimiento { get; set; } = null!;

        // Constructor principal
        public Emprendimiento(string nombre, string? descripcion, int idFacultad, int idRubro)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            IdFacultad = idFacultad;
            IdRubroEmprendimiento = idRubro;
        }

        // Método 1: Cambiar el logo
        public void ActualizarLogo(string nuevaRuta)
        {
            LogoPath = nuevaRuta;
        }

        // Método 2: Editar descripción
        public void EditarDescripcion(string nuevaDescripcion)
        {
            Descripcion = nuevaDescripcion;
        }

        // Método 3: Mostrar información
        public string MostrarInfo()
        {
            return
                $" Emprendimiento: {Nombre}\n" +
                $" Facultad: {Facultad?.Nombre}\n" +
                $" Rubro: {RubroEmprendimiento?.Nombre}\n" +
                $" Descripción: {Descripcion}";
        }

        // Método 4: Verificar facultad
        public bool PerteneceAFacultad(int idFac)
        {
            return IdFacultad == idFac;
        }
    }
}
