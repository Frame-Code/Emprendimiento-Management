namespace WinForms.Views
{
    partial class RegistroEmprendimientoView
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
            TxtNombre = new System.Windows.Forms.TextBox();
            BtnCrear = new System.Windows.Forms.Button();
            CmbFacultad = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            TxtDescripcion = new System.Windows.Forms.TextBox();
            CmbRubro = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            PnlImages = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(304, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(451, 38);
            label1.TabIndex = 0;
            label1.Text = "Registrar nuevo emprendimiento";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new System.Drawing.Point(132, 115);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new System.Drawing.Size(380, 27);
            TxtNombre.TabIndex = 1;
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new System.Drawing.Point(417, 560);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new System.Drawing.Size(247, 44);
            BtnCrear.TabIndex = 2;
            BtnCrear.Text = "Crear emprendimiento";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // CmbFacultad
            // 
            CmbFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbFacultad.FormattingEnabled = true;
            CmbFacultad.Location = new System.Drawing.Point(627, 112);
            CmbFacultad.Name = "CmbFacultad";
            CmbFacultad.Size = new System.Drawing.Size(334, 28);
            CmbFacultad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 115);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(42, 175);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "Descripcion: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(550, 118);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 20);
            label4.TabIndex = 6;
            label4.Text = "Facultad: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(550, 172);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 7;
            label5.Text = "Rubro: ";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new System.Drawing.Point(132, 175);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new System.Drawing.Size(380, 27);
            TxtDescripcion.TabIndex = 9;
            // 
            // CmbRubro
            // 
            CmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbRubro.FormattingEnabled = true;
            CmbRubro.Location = new System.Drawing.Point(627, 172);
            CmbRubro.Name = "CmbRubro";
            CmbRubro.Size = new System.Drawing.Size(339, 28);
            CmbRubro.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label6.Location = new System.Drawing.Point(42, 242);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(90, 20);
            label6.TabIndex = 11;
            label6.Text = "Subir fotos:";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(132, 236);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(213, 32);
            button1.TabIndex = 12;
            button1.Text = "Subir foto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PnlImages
            // 
            PnlImages.Location = new System.Drawing.Point(42, 295);
            PnlImages.Name = "PnlImages";
            PnlImages.Size = new System.Drawing.Size(975, 240);
            PnlImages.TabIndex = 13;
            // 
            // RegistroEmprendimientoView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1048, 627);
            Controls.Add(PnlImages);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(CmbRubro);
            Controls.Add(TxtDescripcion);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CmbFacultad);
            Controls.Add(BtnCrear);
            Controls.Add(TxtNombre);
            Controls.Add(label1);
            Text = "RegistroEmprendimiento";
            Load += RegistroEmprendimiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel PnlImages;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;

        #endregion

        private Label label1;
        private TextBox TxtNombre;
        private System.Windows.Forms.Button BtnCrear;
        private ComboBox CmbFacultad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtDescripcion;
        private ComboBox CmbRubro;
    }
}