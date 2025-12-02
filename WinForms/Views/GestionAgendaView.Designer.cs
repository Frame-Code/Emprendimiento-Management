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
            groupBox1 = new GroupBox();
            btnGuardarCronograma = new Button();
            txtUbicacion = new TextBox();
            label3 = new Label();
            dtHora = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            dtFecha = new DateTimePicker();
            groupBox2 = new GroupBox();
            btnAgregarPresentacion = new Button();
            numericUpDown1 = new NumericUpDown();
            numOrden = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardarCronograma);
            groupBox1.Controls.Add(txtUbicacion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtHora);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtFecha);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(39, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cronograma de Exposición";
            // 
            // btnGuardarCronograma
            // 
            btnGuardarCronograma.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCronograma.Location = new Point(114, 255);
            btnGuardarCronograma.Name = "btnGuardarCronograma";
            btnGuardarCronograma.Size = new Size(87, 31);
            btnGuardarCronograma.TabIndex = 6;
            btnGuardarCronograma.Text = "Guardar";
            btnGuardarCronograma.UseVisualStyleBackColor = true;
            btnGuardarCronograma.Click += btnGuardarCronograma_Click;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUbicacion.Location = new Point(85, 188);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(200, 26);
            txtUbicacion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(15, 191);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Ubicacion";
            // 
            // dtHora
            // 
            dtHora.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.Location = new Point(85, 124);
            dtHora.Name = "dtHora";
            dtHora.Size = new Size(200, 26);
            dtHora.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(15, 124);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 2;
            label2.Text = "Hora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 57);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Fecha";
            // 
            // dtFecha
            // 
            dtFecha.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFecha.Location = new Point(85, 57);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 26);
            dtFecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAgregarPresentacion);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(numOrden);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(498, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 253);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Orden de Presentaciones";
            // 
            // btnAgregarPresentacion
            // 
            btnAgregarPresentacion.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPresentacion.Location = new Point(95, 172);
            btnAgregarPresentacion.Name = "btnAgregarPresentacion";
            btnAgregarPresentacion.Size = new Size(94, 39);
            btnAgregarPresentacion.TabIndex = 8;
            btnAgregarPresentacion.Text = "Agendar";
            btnAgregarPresentacion.UseVisualStyleBackColor = true;
            btnAgregarPresentacion.Click += btnAgregarPresentacion_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Arial", 12F);
            numericUpDown1.Location = new Point(107, 116);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 26);
            numericUpDown1.TabIndex = 7;
            // 
            // numOrden
            // 
            numOrden.Font = new Font("Arial", 12F);
            numOrden.Location = new Point(107, 54);
            numOrden.Name = "numOrden";
            numOrden.Size = new Size(182, 26);
            numOrden.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(28, 57);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 4;
            label5.Text = "Expositor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(28, 118);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 3;
            label4.Text = "Orden";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(280, 29);
            label6.Name = "label6";
            label6.Size = new Size(354, 32);
            label6.TabIndex = 2;
            label6.Text = "Gestion de Eventos y Agenda";
            // 
            // GestionAgendaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 499);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GestionAgendaView";
            Text = "GestionAgendaView";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dtFecha;
        private Button btnGuardarCronograma;
        private TextBox txtUbicacion;
        private Label label3;
        private DateTimePicker dtHora;
        private GroupBox groupBox2;
        private TextBox numOrden;
        private Label label5;
        private Label label4;
        private Button btnAgregarPresentacion;
        private NumericUpDown numericUpDown1;
        private Label label6;
    }
}