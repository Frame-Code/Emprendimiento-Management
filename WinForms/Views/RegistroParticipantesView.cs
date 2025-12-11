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

        public RegistroParticipantesView(RegistroParticipanteController controller)
        {
            _miControlador = controller;
            InitializeComponent();
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
                this.DialogResult = DialogResult.OK;
                this.Close();                       
            }
            else
            {
                MessageBox.Show("Error: " + respuesta.Message);
            }
        }
    }
}
