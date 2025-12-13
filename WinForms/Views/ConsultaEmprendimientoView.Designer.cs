namespace WinForms.Views
{
    partial class ConsultaEmprendimientoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            dgvEmprendimientos = new DataGridView();
            cmbListEmpReg = new ComboBox();
            btnConsultaReg = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmprendimientos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 35);
            label1.Name = "label1";
            label1.Size = new Size(499, 32);
            label1.TabIndex = 0;
            label1.Text = "Consulta de Emprendimientos Registrados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 105);
            label2.Name = "label2";
            label2.Size = new Size(206, 42);
            label2.TabIndex = 1;
            label2.Text = "Listado de Empendimientos \r\nRegistrados:";
            // 
            // dgvEmprendimientos
            // 
            dgvEmprendimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprendimientos.Location = new Point(361, 105);
            dgvEmprendimientos.Name = "dgvEmprendimientos";
            dgvEmprendimientos.Size = new Size(431, 140);
            dgvEmprendimientos.TabIndex = 2;
            // 
            // cmbListEmpReg
            // 
            cmbListEmpReg.FormattingEnabled = true;
            cmbListEmpReg.Location = new Point(95, 159);
            cmbListEmpReg.Name = "cmbListEmpReg";
            cmbListEmpReg.Size = new Size(196, 23);
            cmbListEmpReg.TabIndex = 3;
            // 
            // btnConsultaReg
            // 
            btnConsultaReg.Location = new Point(95, 204);
            btnConsultaReg.Name = "btnConsultaReg";
            btnConsultaReg.Size = new Size(196, 41);
            btnConsultaReg.TabIndex = 4;
            btnConsultaReg.Text = "Consulta";
            btnConsultaReg.UseVisualStyleBackColor = true;
            btnConsultaReg.Click += btnConsultaReg_Click;
            // 
            // ConsultaEmprendimientoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 298);
            Controls.Add(btnConsultaReg);
            Controls.Add(cmbListEmpReg);
            Controls.Add(dgvEmprendimientos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConsultaEmprendimientoView";
            Text = "ConsultaEmpendimientoView";
            Load += ConsultaEmprendimientoView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmprendimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvEmprendimientos;
        private ComboBox cmbListEmpReg;
        private Button btnConsultaReg;
    }
}