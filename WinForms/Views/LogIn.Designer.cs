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
            BtnLogin = new Button();
            TxtUser = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TxtPassword = new TextBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
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
            // BtnLogin
            // 
            BtnLogin.Location = new Point(156, 238);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(236, 39);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Iniciar sesión";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += button1_Click;
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(159, 135);
            TxtUser.Name = "TxtUser";
            TxtUser.PlaceholderText = "Escribe tu nombre de usuario...";
            TxtUser.Size = new Size(342, 27);
            TxtUser.TabIndex = 2;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(206, 305);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(109, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrate aquí";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(248, 285);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 7;
            label4.Text = "O";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 379);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(TxtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtUser);
            Controls.Add(BtnLogin);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnLogin;
        private TextBox TxtUser;
        private Label label2;
        private Label label3;
        private TextBox TxtPassword;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}