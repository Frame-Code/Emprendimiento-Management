using Controller;
using Servicios.Interfaces;
using Shared;
using Shared.ViewRol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Views.UserControls;
using WinForms.Views.Util;

namespace WinForms.Views
{
    public partial class MainEstudianteView : Form, IViewRolForm
    {
        private readonly CalendariodeActividadesView _calendarioActividadesView;
        private readonly ConsultaEmprendimientoUc _consultaUc;
        private readonly GaleriaEmprendimientoView _galeriaEmprendimientoView;
        private readonly VotoEventoUc _votoEventoUc;
        public ViewType ViewType => ViewType.Estudiante;
        public string UserName { get; set; } = "";
        public IEnumerable<MenuOptionsDto> MenuOptionsDto { get; set; }

        public MainEstudianteView(ConsultaEmprendimientoUc consultaUc,
               CalendariodeActividadesView calendarioActividadesView,
               GaleriaEmprendimientoView galeriaEmprendimiento,
               VotoEventoUc votoEventoUc)
        {
            InitializeComponent();
            _consultaUc = consultaUc;
            _calendarioActividadesView = calendarioActividadesView;
            _votoEventoUc = votoEventoUc;
            MenuOptionsDto = new List<MenuOptionsDto>();
            _galeriaEmprendimientoView = galeriaEmprendimiento;
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
            pnlContenedorModuloEst.AutoScroll = true;

            pnlContenedorModuloEst.Controls.Add(control);
            control.BringToFront();
            control.Show();
        }
        private void BtnCalendarioInsano_Click(object sender, EventArgs e)
        {
            try
            {
                NavegarA(_calendarioActividadesView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al cargar el modulo de calendario: " + ex.Message);
            }
        }

        private async void btnGaleria_Click(object sender, EventArgs e)
        {
            try
            {
                await _galeriaEmprendimientoView.Init(UserName);
                NavegarA(_galeriaEmprendimientoView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al cargar la galería: " + ex.Message);
            }
        }

        private async void BtnVotarView_Click(object sender, EventArgs e)
        {
            await _votoEventoUc.Init(UserName);
            NavegarA(_votoEventoUc);

        }

        private void BotonCalendario_Click(object sender, EventArgs e)
        {
            try
            {
                NavegarA(_calendarioActividadesView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al cargar el modulo de calendario: " + ex.Message);
            }
        }
        
    }
}
