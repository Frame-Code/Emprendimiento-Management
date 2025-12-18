namespace WinForms.Views
{
    partial class GestionEventoView
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
            btnCrearEvento = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtNombreEvento = new System.Windows.Forms.TextBox();
            cmbEmprendimiento = new System.Windows.Forms.ComboBox();
            dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            txtUbicacion = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            SuspendLayout();
            // 
            // btnCrearEvento
            // 
            btnCrearEvento.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btnCrearEvento.Location = new System.Drawing.Point(267, 285);
            btnCrearEvento.Name = "btnCrearEvento";
            btnCrearEvento.Size = new System.Drawing.Size(641, 41);
            btnCrearEvento.TabIndex = 0;
            btnCrearEvento.Text = "Registrar evento";
            btnCrearEvento.UseVisualStyleBackColor = true;
            btnCrearEvento.Click += btnCrearEvento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(45, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 216);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Ubicacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(45, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "Descripcion";
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new System.Drawing.Point(136, 107);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.Size = new System.Drawing.Size(462, 27);
            txtNombreEvento.TabIndex = 4;
            // 
            // cmbEmprendimiento
            // 
            cmbEmprendimiento.FormattingEnabled = true;
            cmbEmprendimiento.Location = new System.Drawing.Point(785, 213);
            cmbEmprendimiento.Name = "cmbEmprendimiento";
            cmbEmprendimiento.Size = new System.Drawing.Size(362, 28);
            cmbEmprendimiento.TabIndex = 5;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new System.Drawing.Point(774, 102);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new System.Drawing.Size(373, 27);
            dtpFechaInicio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label4.Location = new System.Drawing.Point(418, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(382, 48);
            label4.TabIndex = 7;
            label4.Text = "Crear nuevo evento";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(136, 156);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(462, 27);
            txtDescripcion.TabIndex = 8;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new System.Drawing.Point(136, 216);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new System.Drawing.Size(462, 27);
            txtUbicacion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(656, 107);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 20);
            label5.TabIndex = 10;
            label5.Text = "Inicio Evento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(656, 163);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(77, 20);
            label6.TabIndex = 11;
            label6.Text = "Fin Evento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(656, 219);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(123, 20);
            label7.TabIndex = 12;
            label7.Text = "Emprendimiento:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFechaFin.Location = new System.Drawing.Point(774, 163);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new System.Drawing.Size(373, 27);
            dtpFechaFin.TabIndex = 13;
            // 
            // GestionEventoView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1177, 355);
            Controls.Add(dtpFechaFin);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUbicacion);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(dtpFechaInicio);
            Controls.Add(cmbEmprendimiento);
            Controls.Add(txtNombreEvento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearEvento);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Text = "GestionEventoView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCrearEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.ComboBox cmbEmprendimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}