using Controller;
using Shared;
using System.Globalization;
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
        private readonly AgendaController _agendaController;
        private readonly EventoController _eventoController;

        public GestionAgendaView(AgendaController agendaController, EventoController eventoController)
        {
            InitializeComponent();
            _agendaController = agendaController;
            _eventoController = eventoController;

            this.Load += GestionAgendaView_Load;
        }
        private bool cargando = false;

        private async void GestionAgendaView_Load(object sender, EventArgs e)
        {
            cargando = true;

            cmbEvento.DataSource = await _eventoController.ListarEventosAsync();
            cmbEvento.DisplayMember = "Nombre";
            cmbEvento.ValueMember = "Id";
            cmbEvento.SelectedIndex = -1;

            cmbExpositor.DataSource = await _agendaController.ListarExpositoresAsync();
            cmbExpositor.DisplayMember = "Nombre";
            cmbExpositor.ValueMember = "Id";
            cmbExpositor.SelectedIndex = -1;

            cargando = false;
        }

        private async void cmbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando || cmbEvento.SelectedIndex == -1)
                return;

            int idEvento = (int)cmbEvento.SelectedValue;
            dgAgenda.DataSource = await _agendaController.ListarAgendaPorEventoAsync(idEvento);
        }



        private async void btnAgregarPresentacion_Click(object sender, EventArgs e)
        {
            if (cmbEvento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un evento.");
                return;
            }

            if (cmbExpositor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un expositor.");
                return;
            }

            int idEvento = (int)cmbEvento.SelectedValue;
            int idExpo = (int)cmbExpositor.SelectedValue;

            var listaActual = await _agendaController.ListarAgendaPorEventoAsync(idEvento);
            int orden = listaActual.Any() ? listaActual.Max(a => a.Orden) + 1 : 1;

            var dto = new AgendaPresentacionDto
            {
                IdEvento = idEvento,
                IdEmprendimiento = idExpo,
                Orden = orden
            };

            var result = await _agendaController.RegistrarAgendaPresentacionAsync(dto);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.Message);
                return;
            }

            MessageBox.Show($"Presentación agregada con orden #{orden}");

            dgAgenda.DataSource = await _agendaController.ListarAgendaPorEventoAsync(idEvento);
        }



    }
}
