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

namespace WinForms.Views
{
    public partial class MainEstudianteView : Form, IViewRolForm
    {
        private readonly ConsultaEmprendimientoView _consultaView;
        public ViewType ViewType => ViewType.Estudiante;
        public string UserName { get; set; } = "Usuario";
        public IEnumerable<MenuOptionsDto> MenuOptionsDto { get; set; }

        public MainEstudianteView(ConsultaEmprendimientoView consultaView)
        {
            _consultaView = consultaView;
            Utils.ConfigureForm(this);
        }

        private void btnEmprendimientoReg_Click(object sender, EventArgs e)
        {
            _consultaView.ShowDialog();
        }

        public void ShowForm(Action closeWindows)
        {
            InitializeComponent();
            LblUserName.Text = UserName;
            FormClosed += (s, e) => closeWindows();
            Show();
        }
    }
}
