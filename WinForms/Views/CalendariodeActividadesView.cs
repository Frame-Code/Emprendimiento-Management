using Controller;
using Datos.Impl;
using Servicios.Impl;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Views;
using WinForms.Views.Util;

namespace WinForms.Views

{
    public partial class CalendariodeActividadesView : Form
    {

        private readonly CalendarioController _controller;

        public CalendariodeActividadesView(CalendarioController controller)
        {
            _controller = controller;
            InitializeComponent();
            Utils.ConfigureForm(this);
        }

        private async void CalendariodeActividadesView_Load(object sender, EventArgs e)
        {
            await CargarDatosAsync();
        }

        private async Task CargarDatosAsync()
        { 
            var facultades = await _controller.ListarFacultadesAsync();
            cmbFacultad.DataSource = facultades;
            cmbFacultad.DisplayMember = "Nombre";
            cmbFacultad.ValueMember = "Id";

            var actividades = await _controller.ListarActividadesAsync();
            dgvActividades.DataSource = null;
            dgvActividades.DataSource = actividades;
        }


        private async void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbFacultad.SelectedValue != null)
            {
                int id = (int)cmbFacultad.SelectedValue;
                var filtradas = await _controller.FiltrarPorFacultadAsync(id);
                dgvActividades.DataSource = filtradas;
            }
            else
            {
                var todas = await _controller.ListarActividadesAsync();
                dgvActividades.DataSource = todas;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private async void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = e.Start;
            var listaFiltrada = await _controller.FiltrarPorFechaAsync(fechaSeleccionada);
            dgvActividades.DataSource = listaFiltrada;
        }
    }
}


