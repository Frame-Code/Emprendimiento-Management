using Controller;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Views.Util;

namespace WinForms.Views
{
    public partial class UserRegister : Form
    {
        public ViewType _ViewType { get; set; }
        public AuthController _controller;
        public UserRegister(AuthController controller)
        {
            _controller = controller;
            InitializeComponent();
            Utils.ConfigureForm(this);
        }

        private async void BtnSignUp_Click(object sender, EventArgs e)
        {
            var isSuccess = Utils.ValidateStrings(TxtUser.Text, TxtPassword.Text, TxtConfirmPassword.Text);
            if (!isSuccess)
            {
                MessageBox.Show("Por favor rellena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TxtPassword.Text != TxtConfirmPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isAvailableUsername = await _controller.IsAvailableUsername(TxtUser.Text);
            if (!isAvailableUsername)
            {
                MessageBox.Show("El nombre de usuario ya está en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rolCode = _controller.GetRolCodeByViewType(_ViewType);
            ResponseDto response = await _controller.RegisterUser(TxtUser.Text, TxtPassword.Text, rolCode);
            if (response.IsSuccess)
            {
                MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show($"Error al registrar el usuario: {response.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
