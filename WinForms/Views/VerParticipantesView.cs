using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using System.Data;
using System.Data.SqlClient;

namespace WinForms.Views.Util
{
    public partial class VerParticipantesView : Form
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
        }

        private async Task CargarParticipantes()
        {
            try
            {
                var lista = await _registroParticipanteController.ObtenerTodos();

                dgvParticipantes.AutoGenerateColumns = true;
                dgvParticipantes.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando datos: " + ex.Message);
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
