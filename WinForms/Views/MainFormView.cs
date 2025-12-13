using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinForms.Views;
using WinForms.Views.Util;
using Datos.Interfaces;
using Datos.Impl;
using Servicios.Interfaces;
using Servicios.Impl;
using Controller;
using Shared;

namespace WinForms
{
    public partial class MainFormView : Form
    {
        private readonly EmprendimientosUc _emprendimientosUc;
        private readonly VerParticipantesView _verParticipantesView;

        public MainFormView(EmprendimientosUc emprendimientosUc, VerParticipantesView verParticipantesView)
        {
            _emprendimientosUc = emprendimientosUc;
            _verParticipantesView = verParticipantesView;
            InitializeComponent();
        }

        private void CargarModulo(UserControl modulo)
        {
            PnlContenedor.Controls.Clear();
            modulo.Dock = DockStyle.Fill;
            PnlContenedor.Controls.Add(modulo);
        }

        private void BtnEmprendimiento_Click(object sender, EventArgs e)
        {
            CargarModulo(_emprendimientosUc);
        }

        private void BtnParticipantes_Click(object sender, EventArgs e)
        {
            try
            {

                VerParticipantesView participantesView = _verParticipantesView;
                participantesView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir participantes: " + ex.Message);
            }
        }
    }
}