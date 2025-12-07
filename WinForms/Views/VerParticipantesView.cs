using System;
using System.Windows.Forms;
using WinForms.Views;
using Datos.Impl;

namespace WinForms.Views.Util
{
    public partial class VerParticipantesView : Form
    {
        private RegistroParticipantesView _registroParticipantesView;
        public VerParticipantesView(RegistroParticipantesView registroParticipantesView)
        {
            _registroParticipantesView = registroParticipantesView;
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmprendimiento = 1; // aquí tienes que poner el id real del emprendimiento, auqneu nose porque lo pides, ya me explicas

                var formRegistro = _registroParticipantesView;
                formRegistro.Init(idEmprendimiento);

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
