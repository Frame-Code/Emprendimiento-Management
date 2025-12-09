namespace WinForms.Views
{
    partial class LogIn
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
            TxtLogIn = new Button();
            this.TxtUser = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 49);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 0;
            label1.Text = "Inicio de sesión";
            // 
            // TxtLogIn
            // 
            TxtLogIn.Location = new Point(145, 269);
            TxtLogIn.Name = "TxtLogIn";
            TxtLogIn.Size = new Size(236, 39);
            TxtLogIn.TabIndex = 1;
            TxtLogIn.Text = "Iniciar sesión";
            TxtLogIn.UseVisualStyleBackColor = true;
            TxtLogIn.Click += button1_Click;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new Point(159, 135);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.PlaceholderText = "Escribe tu nombre de usuario...";
            this.TxtUser.Size = new Size(342, 27);
            this.TxtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 137);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 195);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(159, 196);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PlaceholderText = "Escribe tu contraseña...";
            TxtPassword.Size = new Size(342, 27);
            TxtPassword.TabIndex = 5;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 379);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(this.TxtUser);
            Controls.Add(TxtLogIn);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button TxtLogIn;
        private TextBox TxtUser;
        private Label label2;
        private Label label3;
        private TextBox TxtPassword;
    }
}