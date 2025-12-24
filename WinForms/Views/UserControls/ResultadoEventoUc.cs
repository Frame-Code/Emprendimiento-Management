using Controller;
using Microsoft.Extensions.DependencyInjection;
using Shared;

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
        var dto = 
        GridPremiaciones.DataSource = null;
        GridPremiaciones.DataSource = premiaciones
            .Select(p => new PremiacionGridDto
            {
                Id = p.Id,
                Nombre    = p.Nombre,
                Observacion = p.Observaciones,
                FechaCreacion = p.FechaCreacion,
                FechaFinPremiacion = p.FechaFinPremiacion,
                FechaInicioPremiacion = p.FechaInicioPremiacion
            }).ToList();
        LoadButtons();
    }
    
    private void LoadButtons()
    {
        if (GridPremiaciones.Columns["btnDetalles"] != null)
            GridPremiaciones.Columns.Remove("btnDetalles");

        if (GridPremiaciones.Columns["btnDetalles"] == null)
        {
            DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn
            {
                Name = "btnDetalles",
                HeaderText = @"Acciones",
                Text = "Detalles",
                UseColumnTextForButtonValue = true
            };
            GridPremiaciones.Columns.Add(btnAction);
        }
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

    private async void GridPremiaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (GridPremiaciones.Columns[e.ColumnIndex].Name == "btnDetalles")
        {
            int idPremiacion = (int)GridPremiaciones.Rows[e.RowIndex].Cells["Id"].Value;
            using var  scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<DetallePremiacionView>();
            await form.Init(idPremiacion);
            form.ShowDialog();
        }
    }
}