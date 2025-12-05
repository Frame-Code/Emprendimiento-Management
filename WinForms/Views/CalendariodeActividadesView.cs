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

namespace WinForms.Views
{
    public partial class CalendariodeActividadesView : Form
    {

        public CalendariodeActividadesView()
        {
            InitializeComponent();
        }

        private void CalendariodeActividadesView_Load(object sender, EventArgs e)
        {
            for (int f = 1; f < 96; f++)
            {
                dataGridView1.Rows.Add();
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CmbFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnFiltrar_click_Click(object sender, EventArgs e)
        {
            if (CmbFacultad.SelectedValue is not int idFacultad)
            {
                MessageBox.Show("Seleccione una facultad válida.");
                return;
            }

            var dto = new CalendariodeActividadesDto
            {
                IdFacultad = idFacultad
            };
        }
    }
}
    

