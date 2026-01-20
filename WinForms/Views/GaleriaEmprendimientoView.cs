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
        private readonly IComentarioService _comentarioService;
        private readonly IFotoService _fotoService;
        private FotoDto _fotoSeleccionada;

        // Propiedad para el usuario que viene del Login (puedes setearla desde el Main)
        public string UsuarioActual { get; set; } = "estu";

        public GaleriaEmprendimientoView(IFotoService fotoService, IComentarioService comentarioService)
        {
            InitializeComponent();
            _fotoService = fotoService;
            _comentarioService = comentarioService;
            CargarFotos();
        }

        private async void CargarFotos()
        {
            try
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
                        Tag = foto, // Guardamos el objeto completo aquí
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Evento al hacer clic en cada miniatura
                    pbThumbnail.Click += async (s, e) => {
                        var pic = (PictureBox)s;
                        _fotoSeleccionada = (FotoDto)pic.Tag;

                        pbFoto.Image = pic.Image;
                        txtComentario.Clear();

                        // Resaltar la seleccionada
                        foreach (Control c in flpFotos.Controls) c.BackColor = Color.Transparent;
                        pic.BackColor = Color.LightBlue;

                        // CARGAR COMENTARIOS REALES
                        await MostrarComentarios(_fotoSeleccionada.EmprendimientoId);
                    };

                    flpFotos.Controls.Add(pbThumbnail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar fotos: " + ex.Message);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (_fotoSeleccionada == null)
            {
                MessageBox.Show("Por favor, selecciona una foto primero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Escribe un comentario antes de guardar.");
                return;
            }

            // Llamamos al servicio de comentarios (no al de fotos)
            var respuesta = await _comentarioService.Save(
                txtComentario.Text,
                UsuarioActual,
                _fotoSeleccionada.EmprendimientoId
            );

            if (respuesta.IsSuccess)
            {
                txtComentario.Clear();
                // REFRESCAR BURBUJAS AL INSTANTE
                await MostrarComentarios(_fotoSeleccionada.EmprendimientoId);
            }
            else
            {
                MessageBox.Show("Error al guardar: " + respuesta.Message);
            }
        }

        private async Task MostrarComentarios(int idEmprendimiento)
        {
            // Limpiamos el FlowLayoutPanel antes de cargar
            flpComentarios.Controls.Clear();

            var comentarios = await _comentarioService.ListarComentariosAsync(idEmprendimiento);

            if (comentarios == null || !comentarios.Any()) return;

            foreach (var c in comentarios)
            {
                // Crear panel de burbuja
                Panel pnlBurbuja = new Panel
                {
                    Width = flpComentarios.Width - 30,
                    AutoSize = true,
                    BackColor = Color.FromArgb(235, 235, 235),
                    Padding = new Padding(8),
                    Margin = new Padding(5)
                };

                Label lblTexto = new Label
                {
                    // Mostramos nombre del usuario y su comentario
                    Text = $"{c.Usuario?.NombreUsuario ?? "Usuario"}: {c.Texto}\n({c.HoraCreacion:HH:mm})",
                    AutoSize = true,
                    MaximumSize = new Size(pnlBurbuja.Width - 20, 0),
                    Font = new Font("Segoe UI", 9)
                };

                pnlBurbuja.Controls.Add(lblTexto);
                flpComentarios.Controls.Add(pnlBurbuja);
            }

            // Hacer scroll hasta el final para ver el último comentario
            flpComentarios.ScrollControlIntoView(flpComentarios.Controls.OfType<Control>().LastOrDefault());
        }
    }
}