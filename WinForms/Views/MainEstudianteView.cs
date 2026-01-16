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
        private readonly CalendariodeActividadesView _calendarioActividadesview;
        private readonly ConsultaEmprendimientoUc _consultaUc;

        private readonly IFotoService _fotoService;

        private readonly VotoEventoUc _votoEventoUc;

        public ViewType ViewType => ViewType.Estudiante;
        public string UserName { get; set; } = "Usuario";
        public IEnumerable<MenuOptionsDto> MenuOptionsDto { get; set; }
        private FotoDto _fotoSeleccionada;

        public MainEstudianteView(ConsultaEmprendimientoUc consultaUc,
               CalendariodeActividadesView calendarioActividadesview,

               IFotoService fotoService,

               VotoEventoUc votoEventoUc)

        {
            InitializeComponent();
            _consultaUc = consultaUc;
            _calendarioActividadesview = calendarioActividadesview;
            _votoEventoUc = votoEventoUc;
            WindowState = FormWindowState.Maximized;
            Utils.ConfigureForm(this);
            _fotoService = fotoService;

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
        private void BtnCalendarioInsano_Click(object sender, EventArgs e)
        {
            try
            {
                pnlContenedorModuloEst.Controls.Clear();
                CalendariodeActividadesView calendarioView = _calendarioActividadesview;
                calendarioView.Dock = DockStyle.Fill;
                pnlContenedorModuloEst.Controls.Add(calendarioView);
                calendarioView.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error al cargar el modulo de calendario: " + ex.Message);
            }
        }


        private void btnGaleria_Click(object sender, EventArgs e)
        {
            try
            {
                pnlContenedorModuloEst.Controls.Clear();

                // Ahora _fotoService ya no saldrá en rojo porque ya existe arriba
                var vistaGaleria = new GaleriaEmprendimientoView(_fotoService);

                vistaGaleria.Dock = DockStyle.Fill;
                pnlContenedorModuloEst.Controls.Add(vistaGaleria);
                vistaGaleria.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la galería: " + ex.Message);
            }
            }

        private async void BtnVotarView_Click(object sender, EventArgs e)
        {
            await _votoEventoUc.Init(UserName);
            NavegarA(_votoEventoUc);

        }
    }
}
