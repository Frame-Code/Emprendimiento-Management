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
            label3.Location = new Point(44, 190);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(435, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(140, 187);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(435, 31);
            txtApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(601, 156);
            label4.Name = "label4";
            label4.Size = new Size(143, 25);
            label4.TabIndex = 5;
            label4.Text = "Cargo o Función";
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(750, 156);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(266, 33);
            cmbCargo.TabIndex = 6;
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(256, 294);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(582, 48);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Regitrar Participante";
            btnRegistrar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // RegistroParticipantesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 450);
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
            Load += RegistroParticipantesView_Load_1;
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
    }
}