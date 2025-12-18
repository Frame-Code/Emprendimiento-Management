using Controller;
using Shared;
using Shared.ViewRol;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForms.Views.Util;
using WinForms.Views.UserControls;

namespace WinForms.Views
{
    public partial class MainEstudianteView : Form, IViewRolForm
    {
        private readonly ConsultaEmprendimientoUc _consultaUc;
        private readonly GaleriaEmprendimientoView _galeriaEmprendimientoView;

        public ViewType ViewType => ViewType.Estudiante;
        public string UserName { get; set; } = "Usuario";
        public IEnumerable<MenuOptionsDto> MenuOptionsDto { get; set; }

        public MainEstudianteView(
            ConsultaEmprendimientoUc consultaUc,
            GaleriaEmprendimientoView galeriaEmprendimientoView)
        {
            InitializeComponent();

            _consultaUc = consultaUc;
            _galeriaEmprendimientoView = galeriaEmprendimientoView;

            Utils.ConfigureForm(this);
        }

        public void ShowForm(Action closeWindows)
        {
            LblUserName.Text = UserName;
            FormClosed += (s, e) => closeWindows();
            Show();
        }


        private void NavegarA(UserControl control)
        {
            pnlContenedorModuloEst.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContenedorModuloEst.Controls.Add(control);
            control.BringToFront();
        }

        private void btnEmprendimientoReg_Click(object sender, EventArgs e)
        {
            NavegarA(_consultaUc);
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            NavegarA(_galeriaEmprendimientoView);
        }
    }
}
