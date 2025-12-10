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



        private async void GestionAgendaView_Load(object sender, EventArgs e)
        {
            var expositores = await _controller.ListarExpositoresAsync();

            cmbExpositor.DataSource = expositores;
            cmbExpositor.DisplayMember = "Nombre";
            cmbExpositor.ValueMember = "Id";
            cmbExpositor.SelectedIndex = -1;
        }

        private async void btnGuardarCronograma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha y hora pertenecen al evento, no a la agenda.");
        }

        private async void btnAgregarPresentacion_Click(object sender, EventArgs e)
        {
            if (cmbExpositor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un expositor.");
                return;
            }

            int idEvento = 1; 
            int idEmprendimiento = (int)cmbExpositor.SelectedValue;

            var total = await _controller.ListarAgendaPorEventoAsync(idEvento);
            int nuevoOrden = total.Count + 1;

            numOrden.Value = nuevoOrden;

            var dto = new AgendaPresentacionDto
            {
                IdEvento = idEvento,
                IdEmprendimiento = idEmprendimiento,
                Orden = nuevoOrden
            };

            var result = await _controller.RegistrarAgendaPresentacionAsync(dto);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show($"Presentación agendada con orden #{nuevoOrden}");
        }
    }

}
