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

        // 1. ESTE ES EL MÉTODO QUE CARGA LOS PARTICIPANTES EN EL GRID
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

        // 2. ESTE MÉTODO SE EJECUTA CUANDO SE ABRE LA VISTA
        private async void VerParticipantesView_Load(object sender, EventArgs e)
        {
            await CargarParticipantes();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmprendimiento = 1;

                var formRegistro = _registroParticipantesView;
                formRegistro.Init(idEmprendimiento);

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
