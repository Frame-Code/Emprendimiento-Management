using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Views
{
    public partial class MainEstudianteView : Form, ITypeMainForm
    {
        private readonly ConsultaEmprendimientoView _consultaView;
        public ViewType ViewType => ViewType.Estudiante;
        public string UserName { get; set; } = "Usuario";

        public MainEstudianteView(ConsultaEmprendimientoView consultaView)
        {
            _consultaView = consultaView;
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
