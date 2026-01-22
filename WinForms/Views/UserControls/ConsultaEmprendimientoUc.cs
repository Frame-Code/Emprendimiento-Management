using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Views.UserControls;
using WinForms.Views.Util;

namespace WinForms.Views.UserControls
{
    public partial class ConsultaEmprendimientoUc : UserControl
    {
        private readonly EmprendimientoController _controller;
        public ConsultaEmprendimientoUc(EmprendimientoController controller)
        {
            InitializeComponent();
            _controller = controller;
            Utils.ConfigureForm(this);
        }

        private async void ConsultaEmprendimientoUc_Load(object sender, EventArgs e)
        {
            try
            {
                var lista = await _controller.ListarEmprendimientosEstudiantesAsync();

                cmbListEmpReg.DataSource = lista;
                cmbListEmpReg.DisplayMember = "Nombre";
                cmbListEmpReg.ValueMember = "Id";
                cmbListEmpReg.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista: " + ex.Message);
            }
        }

        private async void btnConsultaReg_Click(object sender, EventArgs e)
        {
            if (cmbListEmpReg.SelectedValue != null)
            {
                int id = (int)cmbListEmpReg.SelectedValue;
                await LoadEmprendimiento(id);
            }
        }

        private async Task LoadEmprendimiento(int id)
        {
            try
            {
                var emprendimiento = await _controller.ObtenerPorIdAsync(id);

                if (emprendimiento == null)
                {
                    MessageBox.Show("No se encontró información del emprendimiento.");
                    return;
                }
                
                var tarjeta = CrearTarjetaEmprendimiento(emprendimiento);
                flpResultados.Controls.Clear();
                flpResultados.Controls.Add(tarjeta);
                flpResultados.ScrollControlIntoView(tarjeta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el detalle: " + ex.Message);
            }
        }
        private Panel CrearTarjetaEmprendimiento(Emprendimiento emp)
        {
           
            var panel = new Panel
            {
                Size = new Size(1000, 300),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 10)
            };

           
            var pbFoto = new PictureBox
            {
                Location = new Point(10, 10),
                Size = new Size(130, 130),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.Fixed3D
            };

            var fotoData = emp.Fotos.FirstOrDefault();
            if (fotoData != null && File.Exists(fotoData.ImageUrl))
            {
                pbFoto.ImageLocation = fotoData.ImageUrl;
            }
            panel.Controls.Add(pbFoto);

            int currentY = 10; 
            int textX = 150;   
            int maxTextWidth = 800;
            int spacing = 5;

            
            var lblNombre = new Label
            {
                Text = $"Nombre: {emp.Nombre}",
                Location = new Point(textX, currentY),
                AutoSize = true,
                MaximumSize = new Size(maxTextWidth, 0),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            panel.Controls.Add(lblNombre);
            currentY = lblNombre.Bottom + spacing;


            var lblDescripcion = new Label
            {
                Text = $"Descripción: {emp.Descripcion}",
                Location = new Point(textX, currentY),
                Size = new Size(maxTextWidth, 60),
                AutoEllipsis = true
            };
            panel.Controls.Add(lblDescripcion);
            currentY = lblDescripcion.Bottom + spacing;


            var nombreFacultad = emp.Facultad?.Nombre ?? "Sin Facultad";
            var lblFacultad = new Label
            {
                Text = $"Facultad: {nombreFacultad}",
                Location = new Point(textX, currentY),
                AutoSize = true,
                MaximumSize = new Size(maxTextWidth, 0),
                ForeColor = Color.Gray
            };
            panel.Controls.Add(lblFacultad);
            int alturaNecesaria = lblFacultad.Bottom + 10;

            if (alturaNecesaria > panel.Height)
            {
                panel.Height = alturaNecesaria;
            }

            return panel;
        }
    }
}