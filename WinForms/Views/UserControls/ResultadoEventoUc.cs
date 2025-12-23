using Controller;
using Microsoft.Extensions.DependencyInjection;

namespace WinForms.Views.UserControls;

public partial class ResultadoEventoUc : UserControl
{
    private readonly PremiacionController _controller;
    private readonly IServiceProvider _serviceProvider;
    public ResultadoEventoUc(PremiacionController controller, IServiceProvider serviceProvider)
    {
        _controller = controller;
        _serviceProvider = serviceProvider;
        InitializeComponent();
    }

    private async Task LoadGrid()
    {
        var premiaciones = await  _controller.ListarPremiacionesAsync();
        GridPremiaciones.DataSource = null;
        GridPremiaciones.DataSource = premiaciones;
    }

    private async void ResultadoEventoUc_Load(object sender, EventArgs e)
    {
        await LoadGrid();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        using var  scope = _serviceProvider.CreateScope();
        var form = scope.ServiceProvider.GetRequiredService<RegistroPremiacionView>();
        if (form.ShowDialog() == DialogResult.OK)
        {
            form.Hide();
            MessageBox.Show("¡Premiacion registrada exitosamente!");
        }

        await LoadGrid();
    }
}