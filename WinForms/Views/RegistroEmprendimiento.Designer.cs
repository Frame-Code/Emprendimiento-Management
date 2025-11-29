namespace WinForms.Views
{
    partial class RegistroEmprendimiento
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
            TxtNombre = new TextBox();
            BtnCrear = new Button();
            CmbFacultad = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtDescripcion = new TextBox();
            CmbRubro = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 26);
            label1.Name = "label1";
            label1.Size = new Size(451, 38);
            label1.TabIndex = 0;
            label1.Text = "Registrar nuevo emprendimiento";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(132, 115);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(380, 27);
            TxtNombre.TabIndex = 1;
            // 
            // BtnCrear
            // 
            BtnCrear.Location = new Point(395, 234);
            BtnCrear.Name = "BtnCrear";
            BtnCrear.Size = new Size(247, 44);
            BtnCrear.TabIndex = 2;
            BtnCrear.Text = "Crear emprendimiento";
            BtnCrear.UseVisualStyleBackColor = true;
            BtnCrear.Click += BtnCrear_Click;
            // 
            // CmbFacultad
            // 
            CmbFacultad.FormattingEnabled = true;
            CmbFacultad.Location = new Point(627, 112);
            CmbFacultad.Name = "CmbFacultad";
            CmbFacultad.Size = new Size(334, 28);
            CmbFacultad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 115);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 175);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 5;
            label3.Text = "Descripcion: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 118);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 6;
            label4.Text = "Facultad: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(550, 172);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 7;
            label5.Text = "Rubro: ";
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.Location = new Point(132, 175);
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(380, 27);
            TxtDescripcion.TabIndex = 9;
            // 
            // CmbRubro
            // 
            CmbRubro.FormattingEnabled = true;
            CmbRubro.Location = new Point(627, 172);
            CmbRubro.Name = "CmbRubro";
            CmbRubro.Size = new Size(339, 28);
            CmbRubro.TabIndex = 10;
            // 
            // RegistroEmprendimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 352);
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
            Name = "RegistroEmprendimiento";
            Text = "RegistroEmprendimiento";
            Load += RegistroEmprendimiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtNombre;
        private Button BtnCrear;
        private ComboBox CmbFacultad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtDescripcion;
        private ComboBox CmbRubro;
    }
}