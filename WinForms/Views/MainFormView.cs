
using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

using Controller;
96abbc376d9ddf8b891271b5557aa2c55c2349b6
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

namespace WinForms;

public partial class MainFormView : Form, ITypeMainForm
{
    private readonly EmprendimientosUc _emprendimientosUc;
    public ViewType ViewType => ViewType.Administrador;
    public string UserName { get; set; } = "Usuario";

    public MainFormView(EmprendimientosUc emprendimientosUc)
    {
        _emprendimientosUc = emprendimientosUc;
    }
96abbc376d9ddf8b891271b5557aa2c55c2349b6

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

    public void ShowForm(Action closeWindows)
    {   
        InitializeComponent();
        LblUserName.Text = UserName;
        FormClosed += (s, e) => closeWindows();
        Show();
    }
}