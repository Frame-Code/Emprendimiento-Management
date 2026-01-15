using Controller;
using WinForms.Views.Util;

namespace WinForms.Views.UserControls;

public partial class VotoEventoUc : UserControl
{
    private readonly PremiacionController _controller;
    private int _idEmprendimiento = 0;
    private int _idPremiacion = 0;
    private string? _nombreUsuario = null;
    public VotoEventoUc(PremiacionController controller)
    {
        _controller = controller;
        InitializeComponent();
        Utils.ConfigureForm(this);
    }

    private async void BtnVotar_Click(object sender, EventArgs e)
    {
        if (_idEmprendimiento == 0)
        {
            MessageBox.Show(@"No se ha seleccionado ningún emprendimiento");
            return;
        }
        
        if (_idPremiacion == 0)
        {
            MessageBox.Show(@"No existe premiacion disponible");
            return;
        }

        if (_nombreUsuario is null)
        {
            MessageBox.Show(@"Fatal error: no se encuentra disponible el usuario");
            return;
        }
        
        //Falta mapear el comentario
        var comentario = TxtComentario.Text;
        var response = await _controller.Votar(_idPremiacion, _idEmprendimiento, _nombreUsuario);
        if (response.IsSuccess)
        {
            MessageBox.Show(response.Message);
            return;
        }
        MessageBox.Show(@"Voto registrado correctamente");
        DgvEmprendimientos.DataSource = null;
        BtnVotar.Enabled = false;
        TxtComentario.Enabled = false;
    }

    public async Task Init(string nombreUsuario)
    {
        var premiacionDisponible = await _controller.ObtenerPremiacionDisponible();
        if (premiacionDisponible is null)
        {
            MessageBox.Show(@"No se ha habilitado una premiacion disponible para registrar votaciones");
            BtnVotar.Enabled = false;
            return;
        }

        _idPremiacion = premiacionDisponible.Id;
        var isDisponibleVotar = premiacionDisponible.Votos.All(v => v.NombreUsuario != nombreUsuario);
        if (!isDisponibleVotar)
        {
            MessageBox.Show(@"Solo se puede votar una vez");
            BtnVotar.Enabled = false;
            return;
        }

        var emprendimientos = premiacionDisponible.EmprendimientosDto;
        DgvEmprendimientos.DataSource = emprendimientos;
        _nombreUsuario = nombreUsuario;
        BtnVotar.Enabled = true;
        LoadButtons();
    }
    
    private void VotoEventoUc_Load(object sender, EventArgs e)
    {
        
    }
    private void LoadButtons()
    {
        if (DgvEmprendimientos.Columns["btnAdd"] != null)
            DgvEmprendimientos.Columns.Remove("btnAdd");
        
        if (DgvEmprendimientos.Columns["btnAdd"] == null)
        {
            DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn
            {
                Name = "btnAdd",
                HeaderText = @"Acciones",
                Text = "Seleccionar",
                UseColumnTextForButtonValue = true
            };
            DgvEmprendimientos.Columns.Add(btnAction);
        }
    }
    private void DgvEmprendimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (DgvEmprendimientos.Columns[e.ColumnIndex].Name == "btnAdd")
        {
            _idEmprendimiento = (int)DgvEmprendimientos.Rows[e.RowIndex].Cells["Id"].Value;
            var nombreEmprendimiento = (string)DgvEmprendimientos.Rows[e.RowIndex].Cells["Nombre"].Value;
            LblEmprendimientoSelected.Text = nombreEmprendimiento;
        }
    }
}