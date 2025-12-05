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
    public partial class GestionAgendaView : Form
    {
        private readonly AgendaController _controller;

        public GestionAgendaView(AgendaController controller)
        {
            InitializeComponent();
            _controller = controller;

            this.Load += GestionAgendaView_Load;
        }



        private void GestionAgendaView_Load(object sender, EventArgs e)
        {
            // Solo mientras no los traes de BD:
            cmbExpositor.Items.Add("Emprendimiento A");
            cmbExpositor.Items.Add("Emprendimiento B");
            cmbExpositor.Items.Add("Emprendimiento C");
            cmbExpositor.SelectedIndex = -1;
        }

        private async void btnGuardarCronograma_Click(object sender, EventArgs e)
        {
            bool isValid = Utils.ValidateStrings(txtUbicacion.Text);

            if (!isValid)
            {
                MessageBox.Show("Por favor completa la ubicación.");
                return;
            }

            var dto = new CronogramaDto
            {
                Fecha = dtFecha.Value,
                Hora = dtHora.Value.ToString("HH:mm"),
                Ubicacion = txtUbicacion.Text
            };

            var result = await _controller.RegistrarCronogramaAsync(dto);

            if (!result.IsSuccess)
            {
                MessageBox.Show($"Error: {result.Message}");
                return;
            }

            MessageBox.Show("Cronograma guardado correctamente.");
        }

        private async void btnAgregarPresentacion_Click(object sender, EventArgs e)
        {
            bool isValid = Utils.ValidateStrings(cmbExpositor.Text);

            if (!isValid)
            {
                MessageBox.Show("Ingrese un expositor válido.");
                return;
            }

            // 🔥 OBTENER EL NUEVO ORDEN AUTOMÁTICO
            var presentaciones = await _controller.ListarPresentacionesAsync();
            int nuevoOrden = presentaciones.Count + 1;

            // Si quieres mostrarlo en el NumericUpDown
            numOrden.Value = nuevoOrden;

            // Crear DTO
            var dto = new PresentacionDto
            {
                Expositor = cmbExpositor.Text,
                Orden = nuevoOrden,
                Fecha = dtFecha.Value,
                Hora = dtHora.Value.ToString("HH:mm"),
                Ubicacion = txtUbicacion.Text
            };

            var result = await _controller.RegistrarPresentacionAsync(dto);

            if (!result.IsSuccess)
            {
                MessageBox.Show($"Error: {result.Message}");
                return;
            }

            MessageBox.Show($"Presentación registrada con orden #{nuevoOrden}");
        }
    }

}
