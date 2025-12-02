using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Views.Util;

namespace WinForms
{
    public partial class DetalleEmprendimientoView : Form
    {
        private int IdEmprendimiento { get; set; }
        private readonly ParticipanteController _controller;
        public DetalleEmprendimientoView(ParticipanteController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        public async Task Init(string nombre, string rubro, string? descripcion, string facultad, int idEmprendimiento)
        {
            LblNombre.Text = nombre;
            LblRubro.Text = rubro;
            LblDescripcion.Text = descripcion;
            LblFacultad.Text = facultad;
            IdEmprendimiento = idEmprendimiento;
            var listParticipantes = await _controller.ObtenerNombresParticipantes(idEmprendimiento);
            string participantes = "";
            listParticipantes.ForEach(p =>
            {
                participantes += "- " + p + "\n";
            });
            LblParticipantes.Text = participantes;

            var listCargos = await _controller.ListarCargos();
            var success = Utils.ValidateLists<CargoParticipante>(listCargos);
            if(!success)
            {
                MessageBox.Show("Error no se pudo obtener los cargos a mostrar");
                return;
            }

            CmbCargo.DataSource = listCargos;
            CmbCargo.DisplayMember = "Nombre";
            CmbCargo.ValueMember = "Id";
            CmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void DetalleEmprendimientoView_Load(object sender, EventArgs e)
        {
        }
    }
}
