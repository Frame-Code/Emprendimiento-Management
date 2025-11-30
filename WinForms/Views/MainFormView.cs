using WinForms.Views;

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
}