using Controller;
using Shared;
using WinForms.Views;

namespace WinForms;

public partial class MainFormView : Form, IViewRolType
{
    private readonly EmprendimientosUc _emprendimientosUc;
    public ViewType ViewType => ViewType.Administrador;
    public string UserName { get; set; } = "Usuario";

    public MainFormView(EmprendimientosUc emprendimientosUc)
    {
        _emprendimientosUc = emprendimientosUc;
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

    public void ShowForm(Action closeWindows)
    {   
        InitializeComponent();
        LblUserName.Text = UserName;
        FormClosed += (s, e) => closeWindows();
        Show();
    }
}