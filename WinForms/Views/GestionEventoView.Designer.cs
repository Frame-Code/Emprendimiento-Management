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
            btnCrearEvento = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreEvento = new TextBox();
            cmbEmprendimiento = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            label4 = new Label();
            txtDescripcion = new TextBox();
            txtUbicacion = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpFechaFin = new DateTimePicker();
            SuspendLayout();
            // 
            // btnCrearEvento
            // 
            btnCrearEvento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearEvento.Location = new Point(360, 419);
            btnCrearEvento.Name = "btnCrearEvento";
            btnCrearEvento.Size = new Size(111, 41);
            btnCrearEvento.TabIndex = 0;
            btnCrearEvento.Text = "Crear";
            btnCrearEvento.UseVisualStyleBackColor = true;
            btnCrearEvento.Click += btnCrearEvento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 184);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 343);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Ubicacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 267);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new Point(146, 184);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.Size = new Size(124, 23);
            txtNombreEvento.TabIndex = 4;
            // 
            // cmbEmprendimiento
            // 
            cmbEmprendimiento.FormattingEnabled = true;
            cmbEmprendimiento.Location = new Point(632, 340);
            cmbEmprendimiento.Name = "cmbEmprendimiento";
            cmbEmprendimiento.Size = new Size(156, 23);
            cmbEmprendimiento.TabIndex = 5;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.Location = new Point(537, 187);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 23);
            dtpFechaInicio.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 79);
            label4.Name = "label4";
            label4.Size = new Size(287, 38);
            label4.TabIndex = 7;
            label4.Text = "Gestion de Evento";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(146, 264);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(124, 23);
            txtDescripcion.TabIndex = 8;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(146, 335);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(124, 23);
            txtUbicacion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 187);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 10;
            label5.Text = "Inicio Evento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(449, 267);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 11;
            label6.Text = "Fin Evento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(449, 343);
            label7.Name = "label7";
            label7.Size = new Size(159, 15);
            label7.TabIndex = 12;
            label7.Text = "Emprendimientos disponible";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.Location = new Point(537, 264);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(200, 23);
            dtpFechaFin.TabIndex = 13;
            // 
            // GestionEventoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 529);
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
            Name = "GestionEventoView";
            Text = "GestionEventoView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearEvento;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreEvento;
        private ComboBox cmbEmprendimiento;
        private DateTimePicker dtpFechaInicio;
        private Label label4;
        private TextBox txtDescripcion;
        private TextBox txtUbicacion;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpFechaFin;
    }
}