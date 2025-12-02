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
        public GestionAgendaView()
        {
            InitializeComponent();
        }

        private async void btnGuardarCronograma_Click(object sender, EventArgs e)
        {
            bool isValid = Utils.ValidateStrings(txtUbicacion.Text);

            if (!isValid)
            {
                MessageBox.Show("Por favor completa la ubicación.");
                return;
            }

            var request = new CronogramaRequest
            {
                Fecha = dtFecha.Value,
                Hora = dtHora.Value.ToString("HH:mm"),
                Ubicacion = txtUbicacion.Text
            };

            var result = await _controller.CrearCronogramaAsync(request);

            if (!result.Success)
            {
                MessageBox.Show($"Error: {result.Message}");
                return;
            }

            MessageBox.Show("Cronograma guardado correctamente.");
        }

        private async void btnAgregarPresentacion_Click(object sender, EventArgs e)
        {
            bool isValid = Utils.ValidateStrings(txtExpositor.Text);

            if (!isValid)
            {
                MessageBox.Show("Ingrese un expositor válido.");
                return;
            }

            var request = new PresentacionRequest
            {
                Expositor = txtExpositor.Text,
                Orden = (int)numOrden.Value,
                Fecha = dtFecha.Value,
                Hora = dtHora.Value.ToString("HH:mm"),
                Ubicacion = txtUbicacion.Text
            };

            var result = await _controller.CrearPresentacionAsync(request);

            if (!result.Success)
            {
                MessageBox.Show($"Error: {result.Message}");
                return;
            }

            MessageBox.Show("Presentación registrada.");
        }
    }
}
