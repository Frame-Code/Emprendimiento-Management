using System.Diagnostics;
using Controller;
using Servicios.Interfaces;

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

    private async void BtnReporte_Click(object sender, EventArgs e)
    {
        using var ofd = new SaveFileDialog()
        {
            Title = "Guardar el reporte",
            Filter = "Archivo PDF (*.pdf)|*.pdf",
            DefaultExt = "pdf",
            AddExtension = true,
            FileName = "Reporte.pdf"
        };

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            string ruta = ofd.FileName;
            var response = await _controller.GenerateReport(ruta, TypeReport.PremiacionReporte, IdPremiacion);
            if (!response.IsSuccess)
            {
                MessageBox.Show(response.Message);
                return;
            }
            MessageBox.Show(@"Reporte generado correctamente");
            Process.Start("explorer.exe", $"/select,\"{ruta}\"");
        }
            

        
    }
}