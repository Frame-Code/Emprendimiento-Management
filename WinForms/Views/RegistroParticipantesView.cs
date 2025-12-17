using Controller;
using Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WinForms.Views.Util;

namespace WinForms.Views
{
    public partial class RegistroParticipantesView : Form
    {
        private readonly RegistroParticipanteController _miControlador;
        private readonly FileController _fileController;
        private List<string> filesPath = new List<string>();

        public RegistroParticipantesView(
            RegistroParticipanteController controller,
            FileController fileController)
        {
            _miControlador = controller;
            _fileController = fileController;
            InitializeComponent();
        }

        private async void RegistroParticipantesView_Load(object sender, EventArgs e)
        {
            try
            {
                var cargos = await _miControlador.CargarCargosParaCombo();

                cmbCargo.DataSource = cargos;
                cmbCargo.DisplayMember = "Nombre";
                cmbCargo.ValueMember = "Id";
                cmbCargo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando cargos: " + ex.Message);
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Selecciona una imagen",
                Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.webp",
                Multiselect = true
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            pnlFoto.Controls.Clear();
            var flowLayout = new FlowLayoutPanel();
            flowLayout.FlowDirection = FlowDirection.LeftToRight;
            flowLayout.WrapContents = true;
            flowLayout.AutoScroll = true;
            flowLayout.Dock = DockStyle.Fill;

            pnlFoto.Controls.Add(flowLayout);
            var listPath = ofd.FileNames;

            foreach (var file in ofd.FileNames)
            {
                var pb = new PictureBox
                {
                    Width = 120,
                    Height = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Margin = new Padding(6),
                    BorderStyle = BorderStyle.FixedSingle
                };

                using var fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                using var imgTemp = Image.FromStream(fs);
                pb.Image = new Bitmap(imgTemp);
                pb.Tag = file;
                filesPath.Add(file);
                flowLayout.Controls.Add(pb);
            }
            flowLayout.ResumeLayout();

            filesPath.Clear();
            filesPath.Add(ofd.FileName);

            pnlFoto.Image = Image.FromFile(ofd.FileName);
        }
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!Utils.ValidateStrings(
                txtNombre.Text,
                txtApellido.Text,
                txtNdeIdentificacion.Text,
                txtNdeTelefono.Text))
            {
                MessageBox.Show("Completa los espacios en blanco.");
                return;
            }

            if (cmbCargo.SelectedIndex == -1 || cmbCargo.SelectedValue is not int idCargo)
            {
                MessageBox.Show("Selecciona un cargo.");
                return;
            }

            var files = new List<FileDto>();

            foreach (var path in filesPath)
            {

                var responseFile = _fileController.CopyFile(path);

                if (!responseFile.IsSuccess)
                {
                    MessageBox.Show("Error copiando imagen: " + responseFile.Message);
                    return;
                }

                if (responseFile.Data is not FileDto fileDto)
                {
                    MessageBox.Show("Error procesando imagen");
                    return;
                }

                files.Add(fileDto);
            }

            var nuevoDto = new ParticipanteDto
            {
                Nombres = txtNombre.Text.Trim(),
                Apellidos = txtApellido.Text.Trim(),
                IdCargoParticipante = idCargo,
                NoIdentificacion = txtNdeIdentificacion.Text.Trim(),
                NoTelefono = txtNdeTelefono.Text.Trim(),
                fotos = files
            };

            btnRegistrar.Enabled = false;

            var respuesta = await _miControlador.GuardarParticipante(nuevoDto);

            btnRegistrar.Enabled = true;

            if (respuesta.IsSuccess)
            {
                MessageBox.Show("¡Guardado correctamente!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Error: " + respuesta.Message);
            }
        }
    }
}
