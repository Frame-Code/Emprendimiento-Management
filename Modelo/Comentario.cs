using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Texto { get; set; } = null!;
        public DateTime HoraCreacion { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public int IdEmprendimiento { get; set; }
        public Emprendimiento Emprendimiento { get; set; } = null!;

        public Comentario(string texto, int idUsuario, int idEmp)
        {
            Texto = texto;
            IdUsuario = idUsuario;
            IdEmprendimiento = idEmp;
            HoraCreacion = DateTime.Now;
        }

        //  MÉTODO 1: Editar un comentario
        public void EditarComentario(string nuevoTexto)
        {
            Texto = nuevoTexto;
            HoraCreacion = DateTime.Now; // registrar la hora de edición
        }

        //  MÉTODO 2: Mostrar comentario bonito
        public string MostrarComentario()
        {
            return $"{Usuario.NombreUsuario}: {Texto} ({HoraCreacion})";
        }

        //  MÉTODO 3: ¿Pertenece este comentario a un usuario?
        public bool EsDelUsuario(int idUsuario)
        {
            return IdUsuario == idUsuario;
        }
    }
}
