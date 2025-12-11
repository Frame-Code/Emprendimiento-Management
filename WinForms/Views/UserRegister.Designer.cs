namespace WinForms.Views
{
    partial class UserRegister
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
            TxtPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TxtUser = new TextBox();
            BtnSignUp = new Button();
            label1 = new Label();
            TxtConfirmPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(249, 220);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PlaceholderText = "Escribe tu contraseña...";
            TxtPassword.Size = new Size(342, 27);
            TxtPassword.TabIndex = 11;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 220);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 10;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 162);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 9;
            label2.Text = "Usuario:";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(249, 159);
            TxtUser.Name = "TxtUser";
            TxtUser.PlaceholderText = "Escribe tu nombre de usuario...";
            TxtUser.Size = new Size(342, 27);
            TxtUser.TabIndex = 8;
            // 
            // BtnSignUp
            // 
            BtnSignUp.Location = new Point(173, 351);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(236, 39);
            BtnSignUp.TabIndex = 7;
            BtnSignUp.Text = "Registrarse";
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(200, 74);
            label1.Name = "label1";
            label1.Size = new Size(270, 38);
            label1.TabIndex = 6;
            label1.Text = "Registro de usuario";
            // 
            // TxtConfirmPassword
            // 
            TxtConfirmPassword.Location = new Point(249, 282);
            TxtConfirmPassword.Name = "TxtConfirmPassword";
            TxtConfirmPassword.PlaceholderText = "Repite tu contraseña...";
            TxtConfirmPassword.Size = new Size(342, 27);
            TxtConfirmPassword.TabIndex = 13;
            TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 282);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 12;
            label4.Text = "Repetir Contraseña:";
            // 
            // UserRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 460);
            Controls.Add(TxtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtUser);
            Controls.Add(BtnSignUp);
            Controls.Add(label1);
            Name = "UserRegister";
            Text = "UserRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPassword;
        private Label label3;
        private Label label2;
        private TextBox TxtUser;
        private Button BtnSignUp;
        private Label label1;
        private TextBox TxtConfirmPassword;
        private Label label4;
    }
}