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
    public partial class MainEstudianteView : Form, IViewRolType
    {
        private readonly ConsultaEmprendimientoView _consultaView;
        private readonly CalendariodeActividadesView _calendarioActividadesView;
        public ViewType ViewType => ViewType.Estudiante;
        public string UserName { get; set; } = "Usuario";

        public MainEstudianteView(ConsultaEmprendimientoView consultaView, 
               CalendariodeActividadesView calendarioActividadesView)
        {
            _consultaView = consultaView;
            _calendarioActividadesView = calendarioActividadesView;
            InitializeComponent();
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

        private void BtnCalendarioInsano_Click(object sender, EventArgs e)
        {
            try
            {
                CalendariodeActividadesView calendarioView = _calendarioActividadesView;
                calendarioView.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el modulo de calendario: " + ex.Message);
            }
        }
    }
}
