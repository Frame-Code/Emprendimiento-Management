using System;
using System.Windows.Forms;
using Shared;
using Servicios.Impl;
using Controller;
using Datos.Interfaces;
using WinForms.Views.Util;


namespace WinForms.Views
{
    public partial class RegistroParticipantesView : Form
    {
        private readonly RegistroParticipanteController _miControlador;
        private int _idEmprendimientoActual;

        public RegistroParticipantesView(int idEmprendimiento, RegistroParticipanteController controller)
        {
            InitializeComponent();
            _idEmprendimientoActual = idEmprendimiento;

            _miControlador = controller;
        }

        private async void RegistroParticipantesView_Load(object sender, EventArgs e)
        {
            try
            {

                var cargos = await _miControlador.CargarCargosParaCombo();

                cmbCargo.DataSource = cargos;
                cmbCargo.DisplayMember = "Nombre";
                cmbCargo.ValueMember = "Id";
                cmbCargo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando cargos: " + ex.Message);
            }
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (!Utils.ValidateStrings(txtNombre.Text, txtApellido.Text))
            {
                MessageBox.Show("Completa los nombres y apellidos.");
                return;
            }
            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un cargo.");
                return;
            }


            var nuevoDto = new ParticipanteDto
            {
                Nombres = txtNombre.Text,
                Apellidos = txtApellido.Text,
                IdEmprendimiento = _idEmprendimientoActual,
                IdCargoParticipante = (int)cmbCargo.SelectedValue,
                NoIdentificacion = "0000000000",
                NoTelefono = "0000000000"
            };

            btnRegistrar.Enabled = false;

            var respuesta = await _miControlador.GuardarParticipante(nuevoDto);

            btnRegistrar.Enabled = true;

            if (respuesta.IsSuccess)
            {
                MessageBox.Show("¡Guardado correctamente!");

                // AGREGA ESTAS DOS LÍNEAS:
                this.DialogResult = DialogResult.OK; // Avisa al padre que todo salió bien
                this.Close(); // Cierra la ventana de registro automáticamente
            }
            else
            {
                MessageBox.Show("Error: " + respuesta.Message);
            }
        }

        public RegistroParticipantesView(
            int idEmprendimiento,
            IParticipanteRepository participanteRepo,
            ICargoParticipanteRepository cargoRepo)
        {
            InitializeComponent();
            _idEmprendimientoActual = idEmprendimiento;

            var miServicio = new RegistroParticipanteService(participanteRepo, cargoRepo);

            _miControlador = new RegistroParticipanteController(miServicio);
        }

    }
}