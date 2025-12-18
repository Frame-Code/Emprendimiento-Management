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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConsultaReg = new System.Windows.Forms.Button();
            cmbListEmpReg = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            flpResultados = new System.Windows.Forms.FlowLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnConsultaReg
            // 
            btnConsultaReg.Location = new System.Drawing.Point(661, 92);
            btnConsultaReg.Name = "btnConsultaReg";
            btnConsultaReg.Size = new System.Drawing.Size(399, 34);
            btnConsultaReg.TabIndex = 9;
            btnConsultaReg.Text = "Consultar Emprendimientos";
            btnConsultaReg.UseVisualStyleBackColor = true;
            btnConsultaReg.Click += btnConsultaReg_Click;
            // 
            // cmbListEmpReg
            // 
            cmbListEmpReg.FormattingEnabled = true;
            cmbListEmpReg.Location = new System.Drawing.Point(26, 101);
            cmbListEmpReg.Name = "cmbListEmpReg";
            cmbListEmpReg.Size = new System.Drawing.Size(619, 28);
            cmbListEmpReg.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(206, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(449, 41);
            label1.TabIndex = 5;
            label1.Text = "Consulta de Emprendimientos ";
            // 
            // flpResultados
            // 
            flpResultados.AutoScroll = true;
            flpResultados.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpResultados.Location = new System.Drawing.Point(26, 139);
            flpResultados.Name = "flpResultados";
            flpResultados.Size = new System.Drawing.Size(1034, 377);
            flpResultados.TabIndex = 10;
            flpResultados.WrapContents = false;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(26, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(796, 22);
            label2.TabIndex = 11;
            label2.Text = "Listado de Empendimientos ";
            // 
            // ConsultaEmprendimientoUc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(flpResultados);
            Controls.Add(btnConsultaReg);
            Controls.Add(cmbListEmpReg);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Size = new System.Drawing.Size(1116, 711);
            Load += ConsultaEmprendimientoUc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        #endregion

        private System.Windows.Forms.Button btnConsultaReg;
        private System.Windows.Forms.ComboBox cmbListEmpReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpResultados;
    }
}
