using Controller;
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
        private readonly RegistroEmprendimientoController _controller;
        public EmprendimientosUc(RegistroEmprendimientoController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private async void EmprendimientosUc_Load(object sender, EventArgs e)
        {
            var listEmprendimientos = await _controller.ListarEmprendimientosAsync();
            dataGridView1.DataSource = listEmprendimientos;

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
    }
}
