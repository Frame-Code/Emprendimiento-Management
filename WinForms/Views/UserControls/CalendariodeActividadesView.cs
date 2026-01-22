using Controller;
using Microsoft.Extensions.DependencyInjection;
using WinForms.Views.Util;

namespace WinForms.Views.UserControls
{

    public partial class CalendariodeActividadesView : UserControl
    {
        private IServiceProvider _serviceProvider;
        private readonly CalendarioController _controller;

        public CalendariodeActividadesView(CalendarioController controller, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
            InitializeComponent();
            Utils.ConfigureForm(this);
        }

        private async void CalendariodeActividadesView_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync();
        }

        private async Task CargarDatosAsync()
        {
            
            var facultades = await _controller.ListarFacultadesAsync();

            var opcionDefault = new Modelo.Facultad();
            opcionDefault.Id = 0;
            opcionDefault.Nombre = "Elije tu Facultad...";
            facultades.Insert(0, opcionDefault);


            cmbFacultad.DataSource = facultades;
            cmbFacultad.DisplayMember = "Nombre";
            cmbFacultad.ValueMember = "Id";
            cmbFacultad.SelectedIndex = 0;

            var actividades = await _controller.ListarActividadesAsync();
            dgvActividades.DataSource = null;
            dgvActividades.DataSource = actividades;
        }


        private async void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbFacultad.SelectedValue != null)
            {
                int id = (int)cmbFacultad.SelectedValue;
                var filtradas = await _controller.FiltrarPorFacultadAsync(id);
                dgvActividades.DataSource = filtradas;
            }
            else
            {
                var todas = await _controller.ListarActividadesAsync();
                dgvActividades.DataSource = todas;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = e.Start;
            var listaFiltrada = await _controller.FiltrarPorFechaAsync(fechaSeleccionada);
            dgvActividades.DataSource = listaFiltrada;
        }

        private void cmbFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void BtnCrearEvento_Click(object sender, EventArgs e)
        {
            using var scope = _serviceProvider.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<GestionEventoView>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Hide();
                MessageBox.Show("¡Evento registrado exitosamente!");
            }

            await CargarDatosAsync();
        }
        public void OcultarBotonCrear()
        {
            BtnCrearEvento.Visible = false;
        }
    }
}


