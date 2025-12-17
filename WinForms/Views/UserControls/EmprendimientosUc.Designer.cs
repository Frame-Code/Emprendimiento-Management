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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnNuevo = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            GridEmprendimientos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridEmprendimientos).BeginInit();
            SuspendLayout();
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new System.Drawing.Point(28, 69);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new System.Drawing.Size(268, 43);
            BtnNuevo.TabIndex = 2;
            BtnNuevo.Text = "Nuevo emprendimiento";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(539, 83);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escribe aqui para buscar por nombre...";
            textBox1.Size = new System.Drawing.Size(521, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(355, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(357, 35);
            label1.TabIndex = 0;
            label1.Text = "Gestion de emprendimientos";
            // 
            // GridEmprendimientos
            // 
            GridEmprendimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridEmprendimientos.Location = new System.Drawing.Point(28, 128);
            GridEmprendimientos.Name = "GridEmprendimientos";
            GridEmprendimientos.ReadOnly = true;
            GridEmprendimientos.RowHeadersWidth = 51;
            GridEmprendimientos.Size = new System.Drawing.Size(1032, 479);
            GridEmprendimientos.TabIndex = 4;
            GridEmprendimientos.CellContentClick += datagridview_CellContentClick;
            // 
            // EmprendimientosUc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(GridEmprendimientos);
            Controls.Add(textBox1);
            Controls.Add(BtnNuevo);
            Controls.Add(label1);
            Size = new System.Drawing.Size(1079, 626);
            Load += EmprendimientosUc_Load;
            ((System.ComponentModel.ISupportInitialize)GridEmprendimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnNuevo;
        private TextBox textBox1;
        private Label label1;
        private DataGridView GridEmprendimientos;
    }
}
