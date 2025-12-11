using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Drawing; 

namespace WinForms.Views.Util
{
    internal class Utils
    {
        public static bool ValidateStrings(params string[] inputs)
        {
            foreach (var item in inputs)
            {
                if(string.IsNullOrEmpty(item)) 
                    return false;
            }
            return true;
        }

        public static bool ValidateLists<T>(params IEnumerable<T>[] lists)
        {
            foreach (var list in lists)
            {
                if (list == null || list.Count() == 0)
                    return false;
            }
            return true;
        }

        public static void ConfigureForm(ContainerControl form)
        {
            var font = new Font("Century Gothic", 10F, FontStyle.Regular);
            form.BackColor = Color.FromArgb(245, 245, 245);
            form.Font = font;

            List<Button> buttons = GetAllControls<Button>(form); 
            buttons.ForEach(btn => 
            {
                ConfigureButton(btn);
                btn.MouseEnter += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(41, 128, 185);
                };
                btn.MouseLeave += (s, e) =>
                {
                    btn.BackColor = Color.FromArgb(52, 152, 219);
                };
            });

            List<TextBox> textBoxes = GetAllControls<TextBox>(form);
            textBoxes.ForEach(tb =>
            {
                tb.Font = font;
                tb.BorderStyle = BorderStyle.None;
            });

            List<ComboBox> comboBoxes = GetAllControls<ComboBox>(form);
            comboBoxes.ForEach(cb =>
            {
                ConfigureComboBox(cb, font);
            });

            List<DataGridView> grids = GetAllControls<DataGridView>(form);
            grids.ForEach(grid =>
            {
                ConfigureDataGridView(grid, font);
            });

        }

        public static List<T> GetAllControls<T>(Control parent) where T : Control
        {
            var list = new List<T>();

            foreach (Control c in parent.Controls)
            {
                if (c is T btn)
                    list.Add(btn);

                if (c.HasChildren)
                    list.AddRange(GetAllControls<T>(c));
            }

            return list;
        }

        public static void ConfigureButton(System.Windows.Forms.Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(50, 96, 219); 
            btn.ForeColor = Color.White;
        }

        public static void ConfigureComboBox(ComboBox cb, Font font)
        {
            cb.Font = font;
            cb.FlatStyle = FlatStyle.Flat;
            cb.BackColor = Color.White;
            cb.ForeColor = Color.FromArgb(40, 40, 40);
        }

        public static void ConfigureDataGridView(DataGridView grid, Font font)
        {
            grid.Font = font;
            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.EnableHeadersVisualStyles = false;

            // Encabezados
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font(font.FontFamily, 10F, FontStyle.Bold);
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 32;

            // Filas
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // Bordes de celdas
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(220, 220, 220);

            // Otros detalles
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
        }
    }
}
