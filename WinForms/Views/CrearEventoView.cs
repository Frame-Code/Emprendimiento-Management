using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Views.Util;
using Shared;
using Controller;


namespace WinForms.Views
{
    public partial class CrearEventoView : Form
    {
        private readonly EventoController _controller;
        private readonly RegistroEmprendimientoController _registroController;

        public CrearEventoView()
        {
            InitializeComponent();
        }


        public CrearEventoView(EventoController controller, RegistroEmprendimientoController registroController)
        {
            InitializeComponent();
            _controller = controller;
            _registroController = registroController;

            this.Load += CrearEventoView_Load;
        }

        private async void CrearEventoView_Load(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Trae los emprendimientos desde el controlador
                var emprendimientos = await _controller.ListarEmprendimientosAsync();

                // 2️⃣ Asigna los datos al ComboBox
                cmbEmprendimiento.DataSource = emprendimientos;
                cmbEmprendimiento.DisplayMember = "Nombre";   // Lo que el usuario ve
                cmbEmprendimiento.ValueMember = "Id";         // El valor interno
                cmbEmprendimiento.SelectedIndex = -1;         // Nada seleccionado al inicio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando emprendimientos: " + ex.Message);
            }
        }



        private async void btnCrearEvento_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (!Utils.ValidateStrings(
                    txtNombreEvento.Text,
                    txtFechaInicio.Text,
                    txtFechaFin.Text,
                    txtUbicacion.Text))
            {
                MessageBox.Show("Complete todos los campos obligatorios");
                return;
            }

            // Validar combo
            if (cmbEmprendimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un emprendimiento");
                return;
            }

            string[] formatos = { "dd/MM/yyyy", "dd-MM-yyyy", "dd MM yyyy" };

            if (!DateTime.TryParseExact(txtFechaInicio.Text, formatos,
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaInicio) ||
                !DateTime.TryParseExact(txtFechaFin.Text, formatos,
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaFin))
            {
                MessageBox.Show("Formato de fecha inválido. Use dd/MM/yyyy o dd-MM-yyyy");
                return;
            }

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha fin no puede ser menor a la fecha inicio");
                return;
            }

            // Crear DTO
            var dto = new EventoDto
            {
                Nombre = txtNombreEvento.Text,
                Descripcion = txtDescripcion.Text,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                Ubicacion = txtUbicacion.Text,
                IdEmprendimiento = (int)cmbEmprendimiento.SelectedValue
            };

            // Crear evento en BD
            var result = await _controller.CrearEventoAsync(dto);

            MessageBox.Show(result.IsSuccess
                ? "Evento creado correctamente"
                : result.Message);
        }
    }
}