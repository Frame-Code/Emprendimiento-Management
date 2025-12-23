using Controller;
using Shared;
using WinForms.Views.Util;

namespace WinForms.Views;

public partial class RegistroPremiacionView : Form
{
    private List<int> EmprendimientosSelectedId = new List<int>();
    private readonly EmprendimientoController _controller;
    private readonly PremiacionController _premiacionController;
    public RegistroPremiacionView(EmprendimientoController controller, PremiacionController premiacionController)
    {
        _controller = controller;
        _premiacionController = premiacionController;
        InitializeComponent();
    }

    private async Task LoadGrid()
    {
        var emprendimientos = await _controller.ListarEmprendimientosAsync();
        GridPremiaciones.DataSource = null;
        GridPremiaciones.DataSource = emprendimientos;
        LoadButtons();
    }
    
    private void LoadButtons()
    {
        if (GridPremiaciones.Columns["btnAdd"] != null)
            GridPremiaciones.Columns.Remove("btnAdd");

        if (GridPremiaciones.Columns["btnAdd"] == null)
        {
            DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn
            {
                Name = "btnAdd",
                HeaderText = "Acciones",
                Text = "Agregar emprendimiento",
                UseColumnTextForButtonValue = true
            };
            GridPremiaciones.Columns.Add(btnAction);
        }
    }

    private async void RegistroPremiacion_Load(object sender, EventArgs e)
    {
        DtFechaFin.Format = DateTimePickerFormat.Custom;
        DtFechaFin.CustomFormat = @"dd/MM/yyyy HH:mm";
        DtFechaFin.ShowUpDown = true;
        
        DtFechaInicio.Format = DateTimePickerFormat.Custom;
        DtFechaInicio.CustomFormat = @"dd/MM/yyyy HH:mm";
        DtFechaInicio.ShowUpDown = true;

        await LoadGrid();
    }

    private void GridPremiaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (GridPremiaciones.Columns[e.ColumnIndex].Name == "btnAdd")
        {
            int idEmprendimiento = (int)GridPremiaciones.Rows[e.RowIndex].Cells["Id"].Value;
            int? id = EmprendimientosSelectedId.FirstOrDefault(x => x == idEmprendimiento);
            if(id != 0)
                return;
            
            EmprendimientosSelectedId.Add(idEmprendimiento);
            string nombre = (string)GridPremiaciones.Rows[e.RowIndex].Cells["Nombre"].Value;
            string facultad = (string)GridPremiaciones.Rows[e.RowIndex].Cells["Facultad"].Value;
            LoadListEmprendimientos(nombre, facultad);
        }
    }

    private void LoadListEmprendimientos(string nombreEmprendimiento, string nombreFacultad)
    {
        string texto = $"Nombre: {nombreEmprendimiento}, facultad: {nombreFacultad}";
        if(!LblEmprendimientos.Text.Contains(texto)) 
            LblEmprendimientos.Text = LblEmprendimientos.Text + "\n" + texto;
    }

    private async void BtnRegistrar_Click(object sender, EventArgs e)
    {
        var isSuccess = Utils.ValidateStrings(TxtNombre.Text);
        if (!isSuccess)
        {
            MessageBox.Show(@"Escribe un nombre de la premiacion");
            return;
        }

        if (DtFechaFin.Value < DtFechaInicio.Value)
        {
            MessageBox.Show(@"Escribe correctamente el rango de fecha");
            return;
        }

        var emprendimientos = new List<EmprendimientoDto>();
        EmprendimientosSelectedId.ForEach(e =>
        {
            emprendimientos.Add(new EmprendimientoDto
            {
                Id = e
            });
        });

        var response = await _premiacionController.CrearPremiacionAsync(new PremiacionDto
        {
            Nombre = TxtNombre.Text,
            Observaciones = TxtObservacion.Text,
            FechaFinPremiacion = DtFechaFin.Value,
            FechaInicioPremiacion = DtFechaInicio.Value,
            EmprendimientosDto = emprendimientos
        });

        if (!response.IsSuccess)
        {
            MessageBox.Show(@"Error al crear la premiacion: " +  response.Message);
            return;
        }
        
        MessageBox.Show(@"Se creo la premiacion correctamente");
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}