using WinForms.Views;
using Controller;
using Servicios.Impl;


namespace WinForms;

public partial class MainFormView : Form
{
    private readonly EmprendimientosUc _emprendimientosUc;
    private readonly CalendariodeActividadesView _calendariodeActividadesview;
    public MainFormView(EmprendimientosUc emprendimientosUc, CalendariodeActividadesView calendariodeActividadesview)
    {
        _emprendimientosUc = emprendimientosUc;
        _calendariodeActividadesview = calendariodeActividadesview;
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

    private void BtnCalendario_Click(object sender, EventArgs e)
    {
        try 
        {
            CalendariodeActividadesView calendarioview = _calendariodeActividadesview;
            calendarioview.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar el módulo de calendario: " + ex.Message);
        }
    }
    
}