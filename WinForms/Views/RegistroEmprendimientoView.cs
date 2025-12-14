using Controller;
using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Views.Util;

namespace WinForms.Views
{
    public partial class RegistroEmprendimientoView : Form
    {
        private readonly RegistroEmprendimientoController _controller;
        private readonly FileController _fileController;
        private List<string> filesPath = new List<string>();
        public RegistroEmprendimientoView(RegistroEmprendimientoController controller, FileController fileController)
        {
            _controller = controller;
            _fileController = fileController;
            InitializeComponent();
            Utils.ConfigureForm(this);
        }

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            bool isValid = Utils.ValidateStrings(TxtNombre.Text);
            if (!isValid)
            {
                MessageBox.Show("Por favor, rellena todos los campos correctamente");
                return;
            }

            if (CmbFacultad.SelectedValue is not int idFacultad ||
                CmbRubro.SelectedValue is not int idRubro)
            {
                MessageBox.Show("Error, selecciona una facultad o rubro valido");
                return;
            }

            var files = new List<FileDto>();
            foreach (var path in filesPath)
            {
                var responseFile = _fileController.CopyFile(path);
                if (!responseFile.IsSuccess)
                {
                    MessageBox.Show("Error: " + responseFile.Message);
                    break;
                }

                var data = responseFile.Data;
                if (data is not FileDto fileDto)
                {
                    MessageBox.Show("Error al obtener el archivo, consulte a sistemas");
                    break;
                }
                files.Add(fileDto);
            }
            
            var dto = new RegistroEmprendimientoDto
            {
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                IdFacultad = idFacultad,
                IdRubroEmprendimiento = idRubro,
                fotos = files
            };

            var response = await _controller.RegistrarEmprendimientoAsync(dto);
            if (!response.IsSuccess)
            {
                MessageBox.Show("Error:" + response.Message);
                return;
            }

            MessageBox.Show("Emprendimiento registrado con exito");
        }

        private async void RegistroEmprendimiento_Load(object sender, EventArgs e)
        {
            var listFacultades = await _controller.ListarFacultadesAsync();
            var listRubros = await _controller.ListarRubrosAsync();

            var success = Utils.ValidateLists<Facultad>(listFacultades) &&
                          Utils.ValidateLists<RubroEmprendimiento>(listRubros);
            if (!success)
            {
                MessageBox.Show("Error no se pudo obtener facultades y rubros a mostrar");
                return;
            }

            CmbFacultad.DataSource = listFacultades;
            CmbFacultad.DisplayMember = "Nombre";
            CmbFacultad.ValueMember = "Id";
            CmbFacultad.DropDownStyle = ComboBoxStyle.DropDownList;

            CmbRubro.DataSource = listRubros;
            CmbRubro.DisplayMember = "Nombre";
            CmbRubro.ValueMember = "Id";
            CmbRubro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Selecciona una imagen",
                Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.webp",
                Multiselect = true
            };

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            PnlImages.Controls.Clear();
            var flowLayout = new FlowLayoutPanel();
            flowLayout.FlowDirection = FlowDirection.LeftToRight;
            flowLayout.WrapContents = true;
            flowLayout.AutoScroll = true;
            flowLayout.Dock = DockStyle.Fill;
            
            PnlImages.Controls.Add(flowLayout);
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
        }
    }
}
