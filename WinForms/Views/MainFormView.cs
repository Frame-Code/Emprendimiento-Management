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

        public MainFormView(EmprendimientosUc emprendimientosUc)
        {
            _emprendimientosUc = emprendimientosUc;
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

                VerParticipantesView participantesView = new VerParticipantesView();

                participantesView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir participantes: " + ex.Message);
            }
        }
    }
}