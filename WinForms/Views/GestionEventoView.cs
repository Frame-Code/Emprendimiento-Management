using Controller;
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
    public partial class GestionEventoView : Form
    {
        private readonly EventoController _controller;

        public GestionEventoView(EventoController controller)
        {
            InitializeComponent();
            _controller = controller;
            this.Load += GestionEventoView_Load;
        }



        private async void GestionEventoView_Load(object? sender, EventArgs e)
        {
            try
            {
                var emprendimientos = await _controller.ListarEmprendimientosAsync();

                cmbEmprendimiento.DataSource = emprendimientos;
                cmbEmprendimiento.DisplayMember = "Nombre";
                cmbEmprendimiento.ValueMember = "Id";
                cmbEmprendimiento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando emprendimientos: " + ex.Message);
            }
        }

        private async void btnCrearEvento_Click(object sender, EventArgs e)
        {
            if (!Utils.ValidateStrings(
                   txtNombreEvento.Text,
                   txtUbicacion.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios");
                return;
            }

            if (cmbEmprendimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un emprendimiento");
                return;
            }

            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha fin no puede ser menor a la fecha inicio");
                return;
            }

            var dto = new EventoDto
            {
                Nombre = txtNombreEvento.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                Ubicacion = txtUbicacion.Text.Trim(),
                IdEmprendimiento = (int)(cmbEmprendimiento.SelectedValue ?? -1)
            };

            var result = await _controller.CrearEventoAsync(dto);

            MessageBox.Show(result.IsSuccess
                ? "Evento creado correctamente"
                : result.Message);
        }
    }
}
