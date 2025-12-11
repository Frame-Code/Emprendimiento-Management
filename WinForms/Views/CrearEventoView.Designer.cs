namespace WinForms.Views
{
    partial class CrearEventoView
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombreEvento = new TextBox();
            txtDescripcion = new TextBox();
            label6 = new Label();
            cmbEmprendimiento = new ComboBox();
            label7 = new Label();
            txtUbicacion = new TextBox();
            btnCrearEvento = new Button();
            txtFechaInicio = new DateTimePicker();
            txtFechaFin = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 62);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 0;
            label1.Text = "Gestión del Evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 154);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 209);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(447, 157);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Incio del Evento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(447, 209);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 4;
            label5.Text = "Fin del Evento";
            // 
            // txtNombreEvento
            // 
            txtNombreEvento.Location = new Point(164, 151);
            txtNombreEvento.Name = "txtNombreEvento";
            txtNombreEvento.Size = new Size(130, 23);
            txtNombreEvento.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 209);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(130, 23);
            txtDescripcion.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(447, 272);
            label6.Name = "label6";
            label6.Size = new Size(194, 20);
            label6.TabIndex = 10;
            label6.Text = "Emprendimiento disponible";
            // 
            // cmbEmprendimiento
            // 
            cmbEmprendimiento.FormattingEnabled = true;
            cmbEmprendimiento.Location = new Point(647, 273);
            cmbEmprendimiento.Name = "cmbEmprendimiento";
            cmbEmprendimiento.Size = new Size(166, 23);
            cmbEmprendimiento.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(73, 272);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 12;
            label7.Text = "Ubicacion";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(164, 273);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(140, 23);
            txtUbicacion.TabIndex = 13;
            // 
            // btnCrearEvento
            // 
            btnCrearEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearEvento.Location = new Point(332, 328);
            btnCrearEvento.Name = "btnCrearEvento";
            btnCrearEvento.Size = new Size(120, 46);
            btnCrearEvento.TabIndex = 14;
            btnCrearEvento.Text = "Crear";
            btnCrearEvento.UseVisualStyleBackColor = true;
            btnCrearEvento.Click += btnCrearEvento_Click;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Format = DateTimePickerFormat.Custom;
            txtFechaInicio.Location = new Point(577, 157);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.ShowUpDown = true;
            txtFechaInicio.Size = new Size(200, 23);
            txtFechaInicio.TabIndex = 15;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Format = DateTimePickerFormat.Custom;
            txtFechaFin.Location = new Point(577, 209);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.ShowUpDown = true;
            txtFechaFin.Size = new Size(200, 23);
            txtFechaFin.TabIndex = 16;
            // 
            // CrearEventoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 464);
            Controls.Add(txtFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(btnCrearEvento);
            Controls.Add(txtUbicacion);
            Controls.Add(label7);
            Controls.Add(cmbEmprendimiento);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreEvento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearEventoView";
            Text = "CrearEvento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        
        private TextBox txtNombreEvento;
        private TextBox txtDescripcion;
        private Label label6;
        private ComboBox cmbEmprendimiento;
        private Label label7;
        private TextBox txtUbicacion;
        private Button btnCrearEvento;
        private DateTimePicker txtFechaInicio;
        private DateTimePicker txtFechaFin;
    }
}