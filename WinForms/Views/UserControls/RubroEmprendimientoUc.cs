using Controller;
using Shared;
using Shared.ViewRol;
using WinForms.Views.Util;

namespace WinForms.Views.UserControls;

public partial class RubroEmprendimientoUc : UserControl, IViewRolUc
{
    public ViewType ViewType { get; } = ViewType.Administrador;
    public string UcCode { get; set; } = "RBR";
    private readonly RubroEmprendimientoController _controller;
    public RubroEmprendimientoUc(RubroEmprendimientoController controller)
    {
        _controller = controller;
        InitializeComponent();
        Utils.ConfigureForm(this);
    }

    private async Task LoadGrid()
    {
        var rubros = await _controller.ListarAsync();
        GridRubros.DataSource = null;
        GridRubros.DataSource = rubros;
    }
    
    private async void RubroEmprendimientoUc_Load(object sender, EventArgs e)
    {
        await LoadGrid();
        Utils.ConfigureForm(this);
    }

    private async void BtnRegistrar_Click(object sender, EventArgs e)
    {
        var isSuccess = Utils.ValidateStrings(TxtNombre.Text);
        if (!isSuccess)
        {
            MessageBox.Show("Es necesario que el nombre registrar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var rubro = new RubroEmprendimientoDto()
        {
            Nombre = TxtNombre.Text,
            Description = TxtDescripcion.Text
        };

        await _controller.CreateAsync(rubro);
        await LoadGrid();
        MessageBox.Show("Facultad creada correctamente", "Facultad creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}