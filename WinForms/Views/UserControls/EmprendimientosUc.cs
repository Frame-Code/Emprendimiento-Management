using Controller;
using Microsoft.Extensions.DependencyInjection;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Views
{
    public partial class EmprendimientosUc : UserControl
    {
        private List<EmprendimientoDto> emprendimientos;
        private readonly RegistroEmprendimientoController _controller;
        private readonly IServiceProvider _serviceProvider;

        public EmprendimientosUc(RegistroEmprendimientoController controller, IServiceProvider serviceProvider)
        {
            emprendimientos = new List<EmprendimientoDto>();
            _controller = controller;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        //Helpers-------------------------------------------------
        private async Task Init()
        {
            var listEmprendimientos = await _controller.ListarEmprendimientosAsync();
            emprendimientos = listEmprendimientos;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listEmprendimientos;
            LoadButtons();
        }
        private void LoadButtons()
        {
            if (dataGridView1.Columns["btnDetalles"] != null)
                dataGridView1.Columns.Remove("btnDetalles");

            if (dataGridView1.Columns["btnDel"] != null)
                dataGridView1.Columns.Remove("btnDel");

            if (dataGridView1.Columns["btnDetalles"] == null)
            {
                DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn
                {
                    Name = "btnDetalles",
                    HeaderText = "Acciones",
                    Text = "Detalles",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(btnAction);
            }

            if (dataGridView1.Columns["btnDel"] == null)
            {
                DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn
                {
                    Name = "btnDel",
                    HeaderText = "Acciones",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(btnAction);
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = resultado;
            LoadButtons();
        }

        private async void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDetalles")
            {
                using var scope = _serviceProvider.CreateScope();
                var form = scope.ServiceProvider.GetRequiredService<DetalleEmprendimientoView>();
                int idEmprendimiento = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                var emprendimiento = emprendimientos.FirstOrDefault(emp => emp.Id == idEmprendimiento);
                if(emprendimiento == null)
                {
                    MessageBox.Show("Emprendimiento no encontrado");
                    return;
                }
                await form.Init(emprendimiento.Nombre, emprendimiento.Rubro, emprendimiento?.Descripcion, emprendimiento.Facultad, emprendimiento.Id);
                form.FormClosed += Form_FormClosed;
                form.ShowDialog();
                return;
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDel")
            {
                await _controller.DeleteByIdAsync((int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
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
