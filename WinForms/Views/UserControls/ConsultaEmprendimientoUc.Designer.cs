namespace WinForms.Views.UserControls
{
    partial class ConsultaEmprendimientoUc
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
            btnConsultaReg = new Button();
            cmbListEmpReg = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            flpResultados = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnConsultaReg
            // 
            btnConsultaReg.Location = new Point(528, 114);
            btnConsultaReg.Name = "btnConsultaReg";
            btnConsultaReg.Size = new Size(122, 42);
            btnConsultaReg.TabIndex = 9;
            btnConsultaReg.Text = "Consultar Emprendimientos";
            btnConsultaReg.UseVisualStyleBackColor = true;
            btnConsultaReg.Click += btnConsultaReg_Click;
            // 
            // cmbListEmpReg
            // 
            cmbListEmpReg.FormattingEnabled = true;
            cmbListEmpReg.Location = new Point(288, 125);
            cmbListEmpReg.Name = "cmbListEmpReg";
            cmbListEmpReg.Size = new Size(196, 23);
            cmbListEmpReg.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 114);
            label2.Name = "label2";
            label2.Size = new Size(206, 42);
            label2.TabIndex = 6;
            label2.Text = "Listado de Empendimientos \r\nRegistrados:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 51);
            label1.Name = "label1";
            label1.Size = new Size(499, 32);
            label1.TabIndex = 5;
            label1.Text = "Consulta de Emprendimientos Registrados";
            // 
            // flpResultados
            // 
            flpResultados.AutoScroll = true;
            flpResultados.FlowDirection = FlowDirection.TopDown;
            flpResultados.Location = new Point(171, 184);
            flpResultados.Name = "flpResultados";
            flpResultados.Size = new Size(417, 271);
            flpResultados.TabIndex = 10;
            flpResultados.WrapContents = false;
            // 
            // ConsultaEmprendimientoUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpResultados);
            Controls.Add(btnConsultaReg);
            Controls.Add(cmbListEmpReg);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaEmprendimientoUc";
            Size = new Size(745, 503);
            Load += ConsultaEmprendimientoUc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultaReg;
        private ComboBox cmbListEmpReg;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flpResultados;
    }
}
