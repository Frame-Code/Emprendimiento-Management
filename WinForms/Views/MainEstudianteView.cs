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
using Shared.ViewRol;
using WinForms.Views.Util;
using WinForms.Views.UserControls;

namespace WinForms.Views
{
    public partial class MainEstudianteView : Form, IViewRolForm
    {
        private readonly ConsultaEmprendimientoUc _consultaUc;
        public ViewType ViewType => ViewType.Estudiante;
        public string UserName { get; set; } = "Usuario";
        public IEnumerable<MenuOptionsDto> MenuOptionsDto { get; set; }

        public MainEstudianteView(ConsultaEmprendimientoUc consultaUc)
        {
            InitializeComponent();
            _consultaUc = consultaUc;
            WindowState = FormWindowState.Maximized;
            Utils.ConfigureForm(this);
        }

        public void ShowForm(Action closeWindows)
        {
            LblUserName.Text = UserName;
            FormClosed += (s, e) => closeWindows();
            Show();
        }
        private void btnEmprendimientoReg_Click(object sender, EventArgs e)
        {
            NavegarA(_consultaUc);
        }

        private void NavegarA(UserControl control)
        {
            pnlContenedorModuloEst.Controls.Clear();
            control.Dock = DockStyle.Fill;

            pnlContenedorModuloEst.Controls.Add(control);
            control.BringToFront();
            control.Show();
        }
    }
}
