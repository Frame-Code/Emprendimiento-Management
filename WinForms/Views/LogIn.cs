using Controller;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class LogIn : Form
    {
        private readonly LogInController _controller;
        private readonly IServiceProvider _serviceProvider;
        public LogIn(LogInController controller, IServiceProvider serviceProvider)
        {
            _controller = controller;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            bool success = Utils.ValidateStrings(TxtUser.Text, TxtPassword.Text);
            if (!success)
            {
                MessageBox.Show("Rellena los campos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var responseDto = await _controller.ValidateCredentials(TxtUser.Text, TxtPassword.Text);
            if(!responseDto.IsSuccess)
            {
                MessageBox.Show("Credenciales inválidas, vuelva a intentar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginUserDto? userDto = responseDto.Data as LoginUserDto;
            if (userDto == null)
            {
                MessageBox.Show("Error al iniciar sesion, verifique con sistemas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var response = await _controller.GetViewByRol(userDto.RoleCode); 
            if(!response.IsSuccess)
            {
                MessageBox.Show("Error al definir el rol de usuario: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(response.Data is not ViewType viewType)
            {
                MessageBox.Show("Error al definir el rol de usuario: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Trae el formalario que coincide que tipo de vista que corresponde al rol del usuario logeado
            var mainForm = _serviceProvider.GetServices<ITypeMainForm>()
                .FirstOrDefault(type => type.ViewType == viewType);
            if (mainForm == null)
            {
                MessageBox.Show("Error al cargar la vista principal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.UserName = userDto.Username;
            mainForm.ShowForm(this.Close);
            this.Hide();
        }
    }
}
