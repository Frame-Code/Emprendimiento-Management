using System;
using System.Windows.Forms;
using WinForms.Views;
using Datos.Impl;

namespace WinForms.Views.Util
{
    public partial class VerParticipantesView : Form
    {
        public VerParticipantesView()
        {
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmprendimiento = 1;

                var repoParticipante = new ParticipanteRepositoryImpl();
                var repoCargo = new CargoParticipanteRepositoryImpl();

                RegistroParticipantesView formRegistro = new RegistroParticipantesView(
                    idEmprendimiento,
                    repoParticipante,
                    repoCargo
                );

                if (formRegistro.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("¡El formulario reportó un registro exitoso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el registro: " + ex.Message);
            }
        }
    }
}