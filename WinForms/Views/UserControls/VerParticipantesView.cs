using Controller;
using WinForms.Views.Util;

namespace WinForms.Views.UserControls
{
    public partial class VerParticipantesView : UserControl
    {
        private readonly RegistroParticipanteController _registroParticipanteController;
        private readonly RegistroParticipantesView _registroParticipantesView;

        public VerParticipantesView(
            RegistroParticipanteController registroParticipanteController,
            RegistroParticipantesView registroParticipantesView)
        {
            _registroParticipanteController = registroParticipanteController;
            _registroParticipantesView = registroParticipantesView;
            InitializeComponent();
            Utils.ConfigureForm(this);
        }

        private async Task CargarParticipantes()
        {
            try
            {
                var lista = await _registroParticipanteController.ObtenerParticipantesVista();
                
                dgvParticipantes.DataSource = lista;
                dgvParticipantes.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar participantes: " + ex.Message);
            }
        }

        private async void VerParticipantesView_Load(object sender, EventArgs e)
        {
            await CargarParticipantes();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try
            {

                var formRegistro = _registroParticipantesView;


                if (formRegistro.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("¡Participante registrado exitosamente!");
                    _ = CargarParticipantes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el registro: " + ex.Message);
            }
        }
    }
}
