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

        //Helpers-----------------------------------
        private async Task LoadParticipantes()
        {
            var listParticipantes = await _controller.ObtenerNombresParticipantes(IdEmprendimiento);
            string participantes = "";
            listParticipantes.ForEach(p =>
            {
                participantes += "- " + p + "\n";
            });
            LblParticipantes.Text = participantes;
        }

        public async Task Init(string nombre, string rubro, string? descripcion, string facultad, int idEmprendimiento)
        {
            LblNombre.Text = nombre;
            LblRubro.Text = rubro;
            LblDescripcion.Text = descripcion;
            LblFacultad.Text = facultad;
            IdEmprendimiento = idEmprendimiento;
            await LoadParticipantes();

            var listCargos = await _controller.ListarCargos();
            var success = Utils.ValidateLists<CargoParticipante>(listCargos);
            if (!success)
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

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            var sucess = Utils.ValidateStrings(TxtNombreP.Text, TxtApellidoP.Text, TxtIdentificacionP.Text, TxtTelefonoT.Text);
            if(!sucess)
            {
                MessageBox.Show("Por favor, rellena todos los campos correctamente");
                return;
            }

            if (!long.TryParse(TxtTelefonoT.Text, out _) || !long.TryParse(TxtIdentificacionP.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa un numero de telefono o numero de identificacion valido");
                return;
            }

            if(CmbCargo.SelectedValue is not int idCargo)
            {
                MessageBox.Show("Por favor, selecciona un cargo valido");
                return;
            }

            var participante = new ParticipanteDto
            {
                Nombres = TxtNombreP.Text,
                Apellidos = TxtApellidoP.Text,
                NoIdentificacion = TxtIdentificacionP.Text,
                NoTelefono = TxtTelefonoT.Text,
                IdEmprendimiento = IdEmprendimiento,
                IdCargoParticipante = idCargo
            };

            var response = await _controller.AgregarParticipante(participante);
            if(!response.IsSuccess)
            {
                MessageBox.Show($"Erro al agregar el participante: {response.Message}");
                return;
            }

            MessageBox.Show("Participante agregado correctamente");
            await LoadParticipantes();
        }
    }
}
