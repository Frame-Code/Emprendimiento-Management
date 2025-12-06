using WinForms.Views;
using Datos.Impl;
using WinForms.Views;
using System;
using System.Windows.Forms;
using Datos.Interfaces;
using Datos.Impl;
using Servicios.Interfaces;
using Servicios.Impl;
using Controller;
using Shared;
using Microsoft.Extensions.DependencyInjection;
namespace WinForms;

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
            int idEmprendimiento = 1;

            var repoParticipante = new Datos.Impl.ParticipanteRepositoryImpl();
            var repoCargo = new Datos.Impl.CargoParticipanteRepositoryImpl();

            using (var ventana = new WinForms.Views.RegistroParticipantesView(idEmprendimiento, repoParticipante, repoCargo))
            {
                ventana.ShowDialog();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al abrir participantes: " + ex.Message);
        }
    }
}