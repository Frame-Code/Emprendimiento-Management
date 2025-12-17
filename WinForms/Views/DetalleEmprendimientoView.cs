using Controller;
using Modelo;
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
using Microsoft.Extensions.DependencyInjection;
using WinForms.Views;
using WinForms.Views.Util;

namespace WinForms
{
    public partial class DetalleEmprendimientoView : Form
    {
        private int IdEmprendimiento { get; set; }
        private readonly IServiceProvider _serviceProvider;
        private readonly ParticipanteController _controller;
        public DetalleEmprendimientoView(ParticipanteController controller, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _controller = controller;
            InitializeComponent();
            Utils.ConfigureForm(this);
        }

        //Helpers-----------------------------------
        private async Task LoadGridParticipantes()
        {
            var participantes = await _controller.ListarParticipantes();
            GridParticipantes.DataSource = null;
            GridParticipantes.DataSource = participantes;
            LoadButtons();
        }
        
        private async Task LoadListParticipantes()
        {
            var listParticipantes = await _controller.ObtenerNombresParticipantes(IdEmprendimiento);
            string participantes = "";
            listParticipantes.ForEach(p =>
            {
                participantes += "- " + p + "\n";
            });
            LblParticipantes.Text = participantes;
        }

        private void LoadButtons()
        {
            if (GridParticipantes.Columns["btnAdd"] != null)
                GridParticipantes.Columns.Remove("btnAdd");

            if (GridParticipantes.Columns["btnAdd"] == null)
            {
                DataGridViewButtonColumn btnAction = new DataGridViewButtonColumn
                {
                    Name = "btnAdd",
                    HeaderText = "Acciones",
                    Text = "Agregar participante",
                    UseColumnTextForButtonValue = true
                };
                GridParticipantes.Columns.Add(btnAction);
            }
        }

        public async Task Init(string nombre, string rubro, string? descripcion, string facultad, int idEmprendimiento)
        {
            LblNombre.Text = nombre;
            LblRubro.Text = rubro;
            LblDescripcion.Text = descripcion;
            LblFacultad.Text = facultad;
            IdEmprendimiento = idEmprendimiento;
            await LoadListParticipantes();
            await LoadGridParticipantes();
        }


        private void DetalleEmprendimientoView_Load(object sender, EventArgs e)
        {
        }
        

        private async void GridParticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridParticipantes.Columns[e.ColumnIndex].Name == "btnAdd")
            {
                int idParticipante = (int)GridParticipantes.Rows[e.RowIndex].Cells["Id"].Value;
                var response = await _controller.AgregarParticipante(idParticipante, IdEmprendimiento);
                if (!response.IsSuccess)
                {
                    MessageBox.Show("Error el agregar el participante: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                MessageBox.Show("Participante registrado exitosamente!");
                await LoadListParticipantes();
            }
        }

        private async void BtnNuevoParticipante_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<RegistroParticipantesView>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("¡Participante registrado exitosamente!");
            }
            await LoadListParticipantes();
            await LoadGridParticipantes();
        }
    }
}
