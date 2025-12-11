namespace WinForms.Views
{
    partial class GestionAgendaView
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
            label6 = new Label();
            label5 = new Label();
            btnAgregarPresentacion = new Button();
            label1 = new Label();
            cmbEvento = new ComboBox();
            cmbExpositor = new ComboBox();
            dgAgenda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgAgenda).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(280, 29);
            label6.Name = "label6";
            label6.Size = new Size(390, 32);
            label6.TabIndex = 2;
            label6.Text = "Gestión de la Agenda del Evento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(78, 196);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 4;
            label5.Text = "Expositor";
            // 
            // btnAgregarPresentacion
            // 
            btnAgregarPresentacion.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPresentacion.Location = new Point(128, 284);
            btnAgregarPresentacion.Name = "btnAgregarPresentacion";
            btnAgregarPresentacion.Size = new Size(94, 39);
            btnAgregarPresentacion.TabIndex = 8;
            btnAgregarPresentacion.Text = "Agendar";
            btnAgregarPresentacion.UseVisualStyleBackColor = true;
            btnAgregarPresentacion.Click += btnAgregarPresentacion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 122);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 10;
            label1.Text = "Evento";
            // 
            // cmbEvento
            // 
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Location = new Point(157, 123);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(140, 23);
            cmbEvento.TabIndex = 11;
            // 
            // cmbExpositor
            // 
            cmbExpositor.FormattingEnabled = true;
            cmbExpositor.Location = new Point(157, 196);
            cmbExpositor.Name = "cmbExpositor";
            cmbExpositor.Size = new Size(133, 23);
            cmbExpositor.TabIndex = 12;
            // 
            // dgAgenda
            // 
            dgAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAgenda.Location = new Point(388, 131);
            dgAgenda.Name = "dgAgenda";
            dgAgenda.Size = new Size(351, 292);
            dgAgenda.TabIndex = 13;
            // 
            // GestionAgendaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 499);
            Controls.Add(dgAgenda);
            Controls.Add(cmbExpositor);
            Controls.Add(label6);
            Controls.Add(cmbEvento);
            Controls.Add(label1);
            Controls.Add(btnAgregarPresentacion);
            Controls.Add(label5);
            Name = "GestionAgendaView";
            Text = "GestionDeAgenda";
            ((System.ComponentModel.ISupportInitialize)dgAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Button btnAgregarPresentacion;
        private Label label1;
        private ComboBox cmbEvento;
        private ComboBox cmbExpositor;
        private DataGridView dgAgenda;
    }
}