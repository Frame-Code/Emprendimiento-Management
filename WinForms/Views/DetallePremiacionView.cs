using Controller;

namespace WinForms.Views;

public partial class DetallePremiacionView : Form
{
    private int IdPremiacion = 0;
    private readonly PremiacionController _controller;
    public DetallePremiacionView(PremiacionController controller)
    {
        _controller = controller;
        InitializeComponent();
    }

    public async Task Init(int idPremiacion)
    {
        IdPremiacion = idPremiacion;
        await LoadInfo();
    }

    private async Task LoadInfo()
    {
        var premiacion = await _controller.ObtenerPremiacionPorIdAsync(IdPremiacion);
        if (premiacion == null)
        {
            MessageBox.Show(@"Error: No se ha encontrado la premiacion seleccionada");
            return;
        }

        LblNombre.Text = premiacion.Nombre;
        LblCreacion.Text = premiacion.FechaCreacion.ToLongDateString();
        LblFin.Text = premiacion.FechaFinPremiacion.ToLongDateString();
        LblInicio.Text = premiacion.FechaFinPremiacion.ToLongDateString();
        LblOservacion.Text = premiacion.Observaciones;

        GridEmprendimientos.DataSource = null;
        GridEmprendimientos.DataSource = premiacion.EmprendimientoVoto;
    }
}