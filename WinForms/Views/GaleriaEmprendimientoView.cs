using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Microsoft.EntityFrameworkCore;
using System.IO;
using DbAppContext = Datos.AppContext;
using Servicios.Interfaces; 
using Shared;



namespace WinForms.Views
{
    public partial class GaleriaEmprendimientoView : UserControl
    {
        private int _fotoSeleccionadaId;

        private readonly IFotoService _fotoService;
        private FotoDto _fotoSeleccionada;

        public GaleriaEmprendimientoView(IFotoService fotoService)
        {
            InitializeComponent();
            _fotoService = fotoService;
            CargarFotos();
        }


        private async void CargarFotos()
        {
            flpFotos.Controls.Clear();
            var fotos = await _fotoService.ListarFotosAsync();

            foreach (var foto in fotos)
            {
                var pbThumbnail = new PictureBox
                {
                    Size = new Size(130, 130),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = foto.ImageUrl,
                    Margin = new Padding(10),
                    Cursor = Cursors.Hand,
                    // GUARDAMOS EL OBJETO COMPLETO: Fundamental para el EmprendimientosId
                    Tag = foto,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // UNA SOLA VERSIÓN DEL EVENTO CLICK
                pbThumbnail.Click += (s, e) => {
                    var pic = (PictureBox)s;

                    // 1. Asignamos la foto a la variable que declaraste arriba
                    _fotoSeleccionada = (FotoDto)pic.Tag;

                    // 2. Mostramos la imagen en el cuadro grande y limpiamos texto
                    pbFoto.Image = pic.Image;
                    txtComentario.Clear();

                    // 3. Efecto visual: Resaltamos la foto seleccionada
                    foreach (Control c in flpFotos.Controls) c.BackColor = Color.Transparent;
                    pic.BackColor = Color.LightBlue;
                };

                flpFotos.Controls.Add(pbThumbnail);
            }
        }


        // 1. Declaras una propiedad arriba en tu clase para no "quemar" el ID abajo
        public int UsuarioLogueadoId { get; set; } = 1; // Cámbialo por el ID que necesites

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que _fotoSeleccionada no sea null (se llena al hacer clic en la foto)
            if (_fotoSeleccionada == null || string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Por favor, selecciona una foto y escribe un comentario.");
                return;
            }

            // 2. Creamos el objeto DTO para enviar al servicio
            var comentarioDto = new ComentarioDto
            {
                // Usamos el ID de emprendimiento que viene de la foto seleccionada
                IdEmprendimiento = _fotoSeleccionada.EmprendimientoId,
                Texto = txtComentario.Text,
                IdUsuario = 1, // Cambia este 1 por el ID real de tu tabla Usuarios
                HoraCreacion = DateTime.Now
            };

            // 3. Llamamos al servicio (asegúrate de que _fotoService esté inicializado)
            var respuesta = await _fotoService.GuardarComentarioAsync(comentarioDto);

            if (respuesta.IsSuccess)
            {
                MessageBox.Show("¡Comentario guardado con éxito!");
                txtComentario.Clear();
                // Opcional: recargar la vista si es necesario
            }
            else
            {
                MessageBox.Show("Error al guardar: " + respuesta.Message);
            }
        }
        private void flpFotos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}