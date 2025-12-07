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
    public partial class MainEstudianteView : Form
    {
        private readonly ConsultaEmprendimientoView _consultaView;
        public MainEstudianteView(ConsultaEmprendimientoView consultaView)
        {
            _consultaView = consultaView;
            InitializeComponent();
        }

        private void btnEmprendimientoReg_Click(object sender, EventArgs e)
        {
            _consultaView.ShowDialog();
        }
    }
}
