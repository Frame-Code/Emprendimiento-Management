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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            cmbCargo = new System.Windows.Forms.ComboBox();
            btnRegistrar = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            txtNdeIdentificacion = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtNdeTelefono = new System.Windows.Forms.TextBox();
            btnFoto = new System.Windows.Forms.Button();
            pnlFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pnlFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(44, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(439, 37);
            label1.TabIndex = 0;
            label1.Text = "Registro de nuevos participantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(306, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(903, 105);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(412, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(453, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(1043, 99);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(415, 27);
            txtApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(306, 197);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 20);
            label4.TabIndex = 5;
            label4.Text = "Cargo:";
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new System.Drawing.Point(482, 197);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new System.Drawing.Size(383, 28);
            cmbCargo.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new System.Drawing.Point(466, 289);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(744, 48);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar Participante";
            btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(306, 147);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(133, 20);
            label6.TabIndex = 10;
            label6.Text = "# de Identificación";
            // 
            // txtNdeIdentificacion
            // 
            txtNdeIdentificacion.Location = new System.Drawing.Point(482, 147);
            txtNdeIdentificacion.Name = "txtNdeIdentificacion";
            txtNdeIdentificacion.Size = new System.Drawing.Size(383, 27);
            txtNdeIdentificacion.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(900, 163);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(103, 20);
            label7.TabIndex = 12;
            label7.Text = "# De Telefono";
            // 
            // txtNdeTelefono
            // 
            txtNdeTelefono.Location = new System.Drawing.Point(1043, 156);
            txtNdeTelefono.Name = "txtNdeTelefono";
            txtNdeTelefono.Size = new System.Drawing.Size(412, 27);
            txtNdeTelefono.TabIndex = 13;
            // 
            // btnFoto
            // 
            btnFoto.Location = new System.Drawing.Point(57, 343);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new System.Drawing.Size(206, 40);
            btnFoto.TabIndex = 14;
            btnFoto.Text = "Agregar Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // pnlFoto
            // 
            pnlFoto.Location = new System.Drawing.Point(57, 96);
            pnlFoto.Name = "pnlFoto";
            pnlFoto.Size = new System.Drawing.Size(206, 218);
            pnlFoto.TabIndex = 15;
            pnlFoto.TabStop = false;
            // 
            // RegistroParticipantesView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1475, 433);
            Controls.Add(pnlFoto);
            Controls.Add(btnFoto);
            Controls.Add(txtNdeTelefono);
            Controls.Add(label7);
            Controls.Add(txtNdeIdentificacion);
            Controls.Add(label6);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbCargo);
            Controls.Add(label4);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2);
            Text = "RegistroParticipantesView";
            Load += RegistroParticipantesView_Load;
            ((System.ComponentModel.ISupportInitialize)pnlFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNdeIdentificacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNdeTelefono;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pnlFoto;
    }
}