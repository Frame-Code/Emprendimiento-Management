namespace WinForms.Views.UserControls
{
    partial class EmprendimientosUc
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            BtnNuevo = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(28, 69);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(268, 43);
            BtnNuevo.TabIndex = 2;
            BtnNuevo.Text = "Nuevo emprendimiento";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(539, 83);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escribe aqui para buscar por nombre...";
            textBox1.Size = new Size(521, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 11);
            label1.Name = "label1";
            label1.Size = new Size(357, 35);
            label1.TabIndex = 0;
            label1.Text = "Gestion de emprendimientos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1032, 479);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += datagridview_CellContentClick;
            // 
            // EmprendimientosUc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(BtnNuevo);
            Controls.Add(label1);
            Name = "EmprendimientosUc";
            Size = new Size(1079, 626);
            Load += EmprendimientosUc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnNuevo;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
