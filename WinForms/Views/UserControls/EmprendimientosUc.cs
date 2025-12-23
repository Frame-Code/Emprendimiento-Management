using Controller;
using Microsoft.Extensions.DependencyInjection;
using Shared;
using WinForms.Views.Util;

namespace WinForms.Views.UserControls
{
    public partial class EmprendimientosUc : UserControl
    {
        private List<EmprendimientoDto> emprendimientos;
        private readonly EmprendimientoController _controller;
        private readonly IServiceProvider _serviceProvider;

        public EmprendimientosUc(EmprendimientoController controller, IServiceProvider serviceProvider)
        {
            emprendimientos = new List<EmprendimientoDto>();
            _controller = controller;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            Utils.ConfigureForm(this);
        }

        //Helpers-------------------------------------------------
        private async Task Init()
        {
            emprendimientos = await _controller.ListarEmprendimientosAsync();
            GridEmprendimientos.DataSource = null;
            GridEmprendimientos.DataSource = emprendimientos;
            LoadButtons();
            Utils.ConfigureForm(this);
        }
        private void LoadButtons()
        {
            if (GridEmprendimientos.Columns["btnDetalles"] != null)
                GridEmprendimientos.Columns.Remove("btnDetalles");

            if (GridEmprendimientos.Columns["btnDel"] != null)
                GridEmprendimientos.Columns.Remove("btnDel");

            if (GridEmprendimientos.Columns["btnDetalles"] == null)
            {
                DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn
                {
                    Name = "btnDetalles",
                    HeaderText = "Acciones",
                    Text = "Detalles",
                    UseColumnTextForButtonValue = true
                };
                GridEmprendimientos.Columns.Add(btnAction);
            }

            if (GridEmprendimientos.Columns["btnDel"] == null)
            {
                DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn
                {
                    Name = "btnDel",
                    HeaderText = "Acciones",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                GridEmprendimientos.Columns.Add(btnAction);
            }
        }

        //Eventos---------------------------------------------------------
        private async void EmprendimientosUc_Load(object sender, EventArgs e) => await Init();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBox1.Text.Trim().ToLower();
            var resultado = emprendimientos.Where(emp =>
                emp.Nombre.Trim().ToLower().Contains(filtro))
            .ToList();
            GridEmprendimientos.DataSource = null;
            GridEmprendimientos.DataSource = resultado;
            LoadButtons();
        }

        private async void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridEmprendimientos.Columns[e.ColumnIndex].Name == "btnDetalles")
            {
                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<DetalleEmprendimientoView>();
                int idEmprendimiento = (int)GridEmprendimientos.Rows[e.RowIndex].Cells["Id"].Value;
                EmprendimientoDto? emprendimientoDto = emprendimientos.FirstOrDefault(emp => emp.Id == idEmprendimiento);
                if(emprendimientoDto == null)
                {
                    MessageBox.Show("Emprendimiento no encontrado");
                    return;
                }
                await form.Init(emprendimientoDto.Nombre, emprendimientoDto.Rubro, emprendimientoDto?.Descripcion, emprendimientoDto.Facultad, emprendimientoDto.Id);
                form.FormClosed += Form_FormClosed;
                form.ShowDialog();
                return;
            }

            if (GridEmprendimientos.Columns[e.ColumnIndex].Name == "btnDel")
            {
                await _controller.DeleteByIdAsync((int)GridEmprendimientos.Rows[e.RowIndex].Cells["Id"].Value);
                await Init();
                MessageBox.Show("Emprendimiento eliminado");
            }

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<RegistroEmprendimientoView>();
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private async void Form_FormClosed(object? sender, FormClosedEventArgs e) => await Init();
    }
}
