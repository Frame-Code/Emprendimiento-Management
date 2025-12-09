using System;
using System.Windows.Forms;
using Shared;
using Controller;
using Datos.Interfaces;
using Servicios.Impl;
using WinForms.Views.Util;
using Servicios.Interfaces;

namespace WinForms.Views
{
    public partial class RegistroParticipantesView : Form
    {
        private readonly RegistroParticipanteController _miControlador;
        private readonly IRegistroParticipanteService _miServicio;
        private int _idEmprendimientoActual;

        // Constructor que se usa desde VerParticipantesView
        public RegistroParticipantesView(
            IParticipanteRepository participanteRepo,
            ICargoParticipanteRepository cargoRepo,
            RegistroParticipanteController registroParticipanteController,
            IRegistroParticipanteService registroParticipanteService)
        {
            _miControlador = registroParticipanteController;
            _miServicio = registroParticipanteService;
            InitializeComponent();
        }

        public void Init(int idEmprendimiento)
        {
            _idEmprendimientoActual = idEmprendimiento;
        }

        // Carga inicial del formulario: llena el ComboBox de cargos
        private async void RegistroParticipantesView_Load(object sender, EventArgs e)
        {
            try
            {
                var cargos = await _miControlador.CargarCargosParaCombo();

                cmbCargo.DataSource = cargos;
                cmbCargo.DisplayMember = "Nombre";
                cmbCargo.ValueMember = "Id";

                cmbCargo.SelectedIndex = -1; // dejar así SI haces validación después
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando cargos: " + ex.Message);
            }
        }

        // Click del botón Registrar
        private async void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (!Utils.ValidateStrings(txtNombre.Text, txtApellido.Text, txtNdeIdentificacion.Text
                , txtNdeTelefono.Text))
            {
                MessageBox.Show("Completa los espacios en blanco.");
                return;
            }

            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un cargo.");
                return;
            }

            var nuevoDto = new ParticipanteDto
            {
                Nombres = txtNombre.Text.Trim(),
                Apellidos = txtApellido.Text.Trim(),
                IdEmprendimiento = _idEmprendimientoActual,
                IdCargoParticipante = (int)cmbCargo.SelectedValue,
                NoIdentificacion = txtNdeIdentificacion.Text.Trim(),
                NoTelefono = txtNdeTelefono.Text.Trim()
            };

            btnRegistrar.Enabled = false;

            var respuesta = await _miControlador.GuardarParticipante(nuevoDto);

            btnRegistrar.Enabled = true;

            if (respuesta.IsSuccess)
            {
                MessageBox.Show("¡Guardado correctamente!");
                this.DialogResult = DialogResult.OK; // Para que el padre sepa que fue exitoso
                this.Close();                        // Cierre automático del formulario
            }
            else
            {
                MessageBox.Show("Error: " + respuesta.Message);
            }
        }

        private void txtNEmprendimiento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
