using Controller;
using Modelo;
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
    public partial class RegistroEmprendimiento : Form
    {
        private readonly RegistroEmprendimientoController _controller;
        public RegistroEmprendimiento(RegistroEmprendimientoController controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            bool isValid = Utils.ValidateStrings(TxtNombre.Text, TxtDescripcion.Text);
            if (!isValid)
            {
                MessageBox.Show("Por favor, rellena todos los campos correctamente");
                return;
            }

            if (CmbFacultad.SelectedValue is not int idFacultad ||
                CmbRubro.SelectedValue is not int idRubro)
            {
                MessageBox.Show("Error, selecciona una facultad o rubro valido");
                return;
            }

            var dto = new RegistroEmprendimientoDto
            {
                Nombre = TxtNombre.Text,
                Descripcion = TxtDescripcion.Text,
                IdFacultad = idFacultad,
                IdRubroEmprendimiento = idRubro
            };

            var response = _controller.RegistrarEmprendimientoAsync(dto).Result;
            if (!response.IsSuccess)
            {
                MessageBox.Show("Error:" + response.Message);
                return;
            }

            MessageBox.Show("Emprendimiento registrado con exito");
        }

        private void RegistroEmprendimiento_Load(object sender, EventArgs e)
        {
            var listFacultades = _controller.ListarFacultadesAsync().Result;
            var listRubros = _controller.ListarRubrosAsync().Result;

            var success = Utils.ValidateLists<Facultad>(listFacultades) &&
                          Utils.ValidateLists<RubroEmprendimiento>(listRubros);
            if (!success)
            {
                MessageBox.Show("Error no se pudo obtener facultades y rubros a mostrar");
                return;
            }

            CmbFacultad.DataSource = listFacultades;
            CmbFacultad.DisplayMember = "Nombre";
            CmbFacultad.ValueMember = "Id";

            CmbRubro.DataSource = listRubros;
            CmbRubro.DisplayMember = "Nombre";
            CmbRubro.ValueMember = "Id";
        }
    }
}
