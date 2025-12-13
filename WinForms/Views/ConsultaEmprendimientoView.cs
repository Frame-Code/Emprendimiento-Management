using Controller;
using Datos.Impl;
using Modelo;
using Servicios.Impl;
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
    public partial class ConsultaEmprendimientoView : Form
    {

        private readonly RegistroEmprendimientoController _controller;
        public ConsultaEmprendimientoView(RegistroEmprendimientoController controller)
        {
            _controller = controller;
            InitializeComponent();
            cmbListEmpReg.DropDownStyle = ComboBoxStyle.DropDownList;
            Utils.ConfigureForm(this);
        }
        private async void ConsultaEmprendimientoView_Load(object sender, EventArgs e)
        {
            try
            {
                var lista = await _controller.ListarEmprendimientosAsync();

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

        private async Task LoadEmprendimiento(int id)
        {
            var emprendimiento = await _controller.ObtenerPorIdAsync(id);

            if (emprendimiento != null)
            {
                var listaMostrar = new List<EmprendimientoDto> { emprendimiento };
                dgvEmprendimientos.DataSource = listaMostrar;

                if (dgvEmprendimientos.Columns["Id"] != null) dgvEmprendimientos.Columns["Id"].Visible = false;
                dgvEmprendimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("No se encontró información.");
            }
        }
        private async void btnConsultaReg_Click(object sender, EventArgs e)
        {
            if (cmbListEmpReg.SelectedIndex == -1 || cmbListEmpReg.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un emprendimiento.");
                return;
            }

            try
            {
                int idSeleccionado = (int)cmbListEmpReg.SelectedValue;
                await LoadEmprendimiento(idSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
            }
        }
    }
}
