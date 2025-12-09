namespace WinForms.Views
{
    partial class RegistroParticipantesView
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label4 = new Label();
            cmbCargo = new ComboBox();
            btnRegistrar = new Button();
            label5 = new Label();
            txtNEmprendimiento = new TextBox();
            label6 = new Label();
            txtNdeIdentificacion = new TextBox();
            label7 = new Label();
            txtNdeTelefono = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 19);
            label1.Name = "label1";
            label1.Size = new Size(699, 45);
            label1.TabIndex = 0;
            label1.Text = "Registro de Participantes de Emprendimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 116);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 164);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(150, 158);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(345, 31);
            txtApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 257);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 5;
            label4.Text = "Cargo o Función";
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(225, 257);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(266, 33);
            cmbCargo.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(628, 113);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(361, 48);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Regitrar Participante";
            btnRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 210);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(144, 25);
            label5.TabIndex = 8;
            label5.Text = "Emprendimiento";
            label5.UseMnemonic = false;
            // 
            // txtNEmprendimiento
            // 
            txtNEmprendimiento.Location = new Point(225, 207);
            txtNEmprendimiento.Name = "txtNEmprendimiento";
            txtNEmprendimiento.Size = new Size(64, 31);
            txtNEmprendimiento.TabIndex = 9;
            txtNEmprendimiento.TextChanged += txtNEmprendimiento_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 305);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 10;
            label6.Text = "# de Identificación";
            // 
            // txtNdeIdentificacion
            // 
            txtNdeIdentificacion.Location = new Point(225, 302);
            txtNdeIdentificacion.Name = "txtNdeIdentificacion";
            txtNdeIdentificacion.Size = new Size(266, 31);
            txtNdeIdentificacion.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 347);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 12;
            label7.Text = "# De Telefono";
            // 
            // txtNdeTelefono
            // 
            txtNdeTelefono.Location = new Point(225, 347);
            txtNdeTelefono.Name = "txtNdeTelefono";
            txtNdeTelefono.Size = new Size(266, 31);
            txtNdeTelefono.TabIndex = 13;
            // 
            // RegistroParticipantesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 450);
            Controls.Add(txtNdeTelefono);
            Controls.Add(label7);
            Controls.Add(txtNdeIdentificacion);
            Controls.Add(label6);
            Controls.Add(txtNEmprendimiento);
            Controls.Add(label5);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbCargo);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistroParticipantesView";
            Text = "RegistroParticipantesView";
            Load += RegistroParticipantesView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label4;
        private ComboBox cmbCargo;
        private Button btnRegistrar;
        private Label label5;
        private TextBox txtNEmprendimiento;
        private Label label6;
        private TextBox txtNdeIdentificacion;
        private Label label7;
        private TextBox txtNdeTelefono;
    }
}