using Shared;
using WinForms.Views;
using WinForms.Views.Util;

namespace WinForms;

public partial class MainFormView : Form, IViewRolType
{
    private readonly EmprendimientosUc _emprendimientosUc;
    private readonly CalendariodeActividadesView _calendarioActividadesView;
    private readonly VerParticipantesView _verParticipantesView;
    public ViewType ViewType => ViewType.Administrador;
    public string UserName { get; set; } = "Usuario";

    public MainFormView(EmprendimientosUc emprendimientosUc, CalendariodeActividadesView calendarioActividadesView, VerParticipantesView verParticipantesView)
    {
        _emprendimientosUc = emprendimientosUc;
        _calendarioActividadesView = calendarioActividadesView;
        _verParticipantesView = verParticipantesView;
        InitializeComponent();
        Utils.ConfigureForm(this);
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
    public void ShowForm(Action closeWindows)
    {
        InitializeComponent();
        LblUserName.Text = UserName;
        FormClosed += (s, e) => closeWindows();
        Utils.ConfigureForm(this);
        Show();
    }

    private void BtnEventos_Click(object sender, EventArgs e)
    {
        try
        {
            CalendariodeActividadesView calendarioView = _calendarioActividadesView;
            calendarioView.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar el modulo de calendario: " + ex.Message);
        }
    }
}