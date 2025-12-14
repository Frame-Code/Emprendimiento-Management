using Controller;
using Shared;
using Shared.ViewRol;
using WinForms.Views.Util;

namespace WinForms.Views.UserControls;

public partial class FacultadesUc : UserControl, IViewRolUc
{
    public ViewType ViewType { get; } = ViewType.Administrador;
    public string UcCode { get; set; } = "FCL";
    public FacultadController _controller;
    
    public FacultadesUc(FacultadController controller)
    {
        _controller = controller;
        InitializeComponent();
        Utils.ConfigureForm(this);
    }

    private async Task LoadGrid()
    {
        var facultades = await _controller.ListarAsync();
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = facultades;
    }
    
    private async void FacultadesUc_Load(object sender, EventArgs e)
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

        var facultad = new FacultadDto
        {
            Nombre = TxtNombre.Text,
            Description = TxtDescripcion.Text
        };

        await _controller.SaveAsync(facultad);
        await LoadGrid();
        MessageBox.Show("Rubro emprendimiento creado correctamente", "Facultad creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        
    }
}