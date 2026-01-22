using Datos;
using System;
using WinForms.Views.UserControls; 
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
        private bool _isAlreadyLoading = false;

        public string UsuarioActual { get; set; } = "estu";

        public GaleriaEmprendimientoView(IFotoService fotoService, IComentarioService comentarioService)
        {
            InitializeComponent();
            _fotoService = fotoService;
            _comentarioService = comentarioService;


            flpFotos.WrapContents = true;
            flpFotos.AutoScroll = true;

           
            flpFotos.HorizontalScroll.Enabled = false;
            flpFotos.HorizontalScroll.Visible = false;
            flpFotos.HorizontalScroll.Maximum = 0;


            CargarFotos();
        }

        private async void CargarFotos()
        {
            if (_isAlreadyLoading) return;

            try
            {
                _isAlreadyLoading = true;
                flpFotos.Controls.Clear();

                var fotos = await _fotoService.ListarFotosAsync();
                if (fotos == null) return;

                foreach (var foto in fotos)
                {
                    var pbThumbnail = new PictureBox
                    {
                        Size = new Size(130, 130),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        ImageLocation = foto.ImageUrl,
                        Margin = new Padding(10),
                        Cursor = Cursors.Hand,
                        Tag = foto,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    pbThumbnail.Click += async (s, e) =>
                    {
                        var pic = (PictureBox)s;

                        _fotoSeleccionada = (FotoDto)pic.Tag;
                        if (pbFoto != null) pbFoto.Image = pic.Image;

                        txtComentario.Clear();

                        foreach (Control c in flpFotos.Controls) c.BackColor = Color.Transparent;
                        pic.BackColor = Color.LightBlue;
 
                        await MostrarComentarios(_fotoSeleccionada.EmprendimientoId);
                    };

                    flpFotos.Controls.Add(pbThumbnail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar fotos: " + ex.Message);
            }
            finally
            {
                _isAlreadyLoading = false;
            }
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
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

            var respuesta = await _comentarioService.Save(
                txtComentario.Text,
                UsuarioActual,
                _fotoSeleccionada.EmprendimientoId
            );

            if (respuesta.IsSuccess)
            {
                txtComentario.Clear();
               
                await MostrarComentarios(_fotoSeleccionada.EmprendimientoId);
            }
            else
            {
                MessageBox.Show("Error al guardar: " + respuesta.Message);
            }
        }

        private async Task MostrarComentarios(int idEmprendimiento)
        {
            dgvComentarios.DataSource = null;
            var comentarios = await _comentarioService.ListarComentariosAsync(idEmprendimiento);

            if (comentarios == null || !comentarios.Any()) return;

            // Llenamos el DataGridView con el nuevo campo "Emprendimiento"
            dgvComentarios.DataSource = comentarios.Select(c => new
            {  
                Usuario = c.UsuarioNombre,
                Emprendimiento = c.NombreEmprendimiento,
                Facultad = c.Facultad,
                Rubro = c.RubroNombre,
                Mensaje = c.Texto,
                Hora = c.HoraCreacion.ToString("HH:mm")
            }).ToList();

            if (dgvComentarios.Columns.Count > 0)
            {
                dgvComentarios.ScrollBars = ScrollBars.Both;

                // Ajustamos anchos
                dgvComentarios.Columns["Emprendimiento"].Width = 150;
                dgvComentarios.Columns["Usuario"].Width = 100;
                dgvComentarios.Columns["Facultad"].Width = 120;

                // El mensaje sigue siendo el que se estira (Fill)
                dgvComentarios.Columns["Mensaje"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvComentarios.Columns["Mensaje"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgvComentarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvComentarios.ReadOnly = true;
            }
        }
    }
}