using Shared;
using WinForms.Views.UserControls;
using WinForms.Views.Util;

namespace WinForms.Views;

public partial class MainFormView : Form, IViewRolType
{
    public ViewType ViewType => ViewType.Administrador;
    public string UserName { get; set; } = "Usuario";
    private readonly EmprendimientosUc _emprendimientosUc;
    private readonly CalendariodeActividadesView _calendarioActividadesView;
    private readonly VerParticipantesView _verParticipantesView;

    public MainFormView(EmprendimientosUc emprendimientosUc, CalendariodeActividadesView calendarioActividadesView, VerParticipantesView verParticipantesView)
    {
        _emprendimientosUc = emprendimientosUc;
        _calendarioActividadesView = calendarioActividadesView;
        _verParticipantesView = verParticipantesView;
        InitializeComponent();
        Utils.ConfigureForm(this);
    }
    
    public void ShowForm(Action closeWindows)
    {
        InitializeComponent();
        LblUserName.Text = UserName;
        FormClosed += (s, e) => closeWindows();
        Utils.ConfigureForm(this);
        Show();
    }

    private void CargarModulo(UserControl modulo)
    {
        PnlContenedor.Controls.Clear();
        modulo.Dock = DockStyle.Fill;
        modulo.Visible = true;
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
            CargarModulo(_verParticipantesView);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al abrir participantes: " + ex.Message);
        }
    }

    private void BtnEventos_Click(object sender, EventArgs e)
    {
        try
        {
            CargarModulo(_calendarioActividadesView);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al abrir calendario de actividades: " + ex.Message);

        }
    }
}