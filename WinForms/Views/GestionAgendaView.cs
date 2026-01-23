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
        private readonly AgendaController _agendaController;
        private readonly EventoController _eventoController;

        public GestionAgendaView(
            AgendaController agendaController,
            EventoController eventoController)
        {
            InitializeComponent();
            _agendaController = agendaController;
            _eventoController = eventoController;

            Load += GestionAgendaView_Load;
        }

        private async void GestionAgendaView_Load(object? sender, EventArgs e)
        {
            // Eventos
            cmbEvento.DataSource = await _eventoController.ListarEventosAsync();
            cmbEvento.DisplayMember = "Nombre";
            cmbEvento.ValueMember = "Id";
            cmbEvento.SelectedIndex = -1;

            // Expositores
            cmbExpositor.DataSource = await _agendaController.ListarExpositoresAsync();
            cmbExpositor.DisplayMember = "Nombre";
            cmbExpositor.ValueMember = "Id";
            cmbExpositor.SelectedIndex = -1;
        }

        private async void cmbEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEvento.SelectedIndex == -1) return;

            int idEvento = (int)(cmbEvento.SelectedValue ?? -1);
            dgAgenda.DataSource =
                await _agendaController.ListarAgendaPorEventoAsync(idEvento);
        }

        private async void btnAgregarPresentacion_Click(object sender, EventArgs e)
        {
            if (cmbEvento.SelectedIndex == -1 || cmbExpositor.SelectedIndex == -1)
            {
                MessageBox.Show(@"Seleccione evento y expositor");
                return;
            }

            var dto = new AgendaPresentacionDto
            {
                IdEvento = (int)(cmbEvento.SelectedValue ?? -1),
                IdEmprendimiento = (int)(cmbExpositor.SelectedValue ?? -1)
                
            };

            var result = await _agendaController.RegistrarAgendaPresentacionAsync(dto);
            MessageBox.Show(result.Message);

            dgAgenda.DataSource = await _agendaController.ListarAgendaPorEventoAsync(dto.IdEvento);
        }

    }
}