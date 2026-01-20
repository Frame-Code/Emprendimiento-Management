using Controller;
using Microsoft.Extensions.DependencyInjection;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.ViewRol;
using WinForms.Views.Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms.Views
{
    public partial class LogIn : Form
    {
        private readonly AuthController _controller;
        private readonly MenuOpcionesController _menuOpcionesController;
        private readonly IServiceProvider _serviceProvider;

        public LogIn(AuthController controller, MenuOpcionesController menuOpcionesController, IServiceProvider serviceProvider)
        {
            _controller = controller;
            _menuOpcionesController = menuOpcionesController;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            Utils.ConfigureForm(this);
            WindowState = FormWindowState.Maximized;
            CenterRoundedPanel();
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
            if (!responseDto.IsSuccess)
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
            if (!response.IsSuccess)
            {
                MessageBox.Show("Error al definir el rol de usuario: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (response.Data is not ViewType viewType)
            {
                MessageBox.Show("Error al definir el rol de usuario: " + response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //Trae el formulario que coincide que tipo de vista que corresponde al rol del usuario logeado
            var mainForm = _serviceProvider.GetServices<IViewRolForm>()
                .FirstOrDefault(type => type.ViewType == viewType);
            
            if (mainForm == null)
            {
                MessageBox.Show("Error al cargar la vista principal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainForm.UserName = userDto.Username;
            mainForm.MenuOptionsDto = await _menuOpcionesController.ListarPorRol(userDto.RoleCode);
            mainForm.ShowForm(this.Close);
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;

            var signUpForm = _serviceProvider.GetService<UserRegister>();
            if (signUpForm == null)
            {
                MessageBox.Show("Error al cargar el formulario de registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            signUpForm._ViewType = ViewType.Estudiante;
            signUpForm.ShowDialog();
        }

        private void CenterRoundedPanel()
        {
            int x = (this.ClientSize.Width - roundedPanel1.Width) / 2;
            int y = (this.ClientSize.Height - roundedPanel1.Height) / 2;

            roundedPanel1.Location = new Point(x, y);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            CenterRoundedPanel();
        }
    }
}
