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
            label1 = new System.Windows.Forms.Label();
            BtnLogin = new System.Windows.Forms.Button();
            TxtUser = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            TxtPassword = new System.Windows.Forms.TextBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            label4 = new System.Windows.Forms.Label();
            roundedPanel1 = new WinForms.Views.Util.RoundedPanel();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(160, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(187, 38);
            label1.TabIndex = 0;
            label1.Text = "Iniciar sesión";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new System.Drawing.Point(46, 296);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new System.Drawing.Size(390, 46);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Iniciar sesión";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += button1_Click;
            // 
            // TxtUser
            // 
            TxtUser.Location = new System.Drawing.Point(46, 146);
            TxtUser.Name = "TxtUser";
            TxtUser.PlaceholderText = "Escribe tu nombre de usuario...";
            TxtUser.Size = new System.Drawing.Size(390, 27);
            TxtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(46, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 25);
            label2.TabIndex = 3;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.Location = new System.Drawing.Point(46, 201);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña:";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new System.Drawing.Point(46, 229);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PlaceholderText = "Escribe tu contraseña...";
            TxtPassword.Size = new System.Drawing.Size(390, 27);
            TxtPassword.TabIndex = 5;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(200, 397);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(109, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrate aquí";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(46, 397);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(134, 20);
            label4.TabIndex = 7;
            label4.Text = "¿No tienes cuenta?";
            label4.Click += label4_Click;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.White;
            roundedPanel1.BorderColor = System.Drawing.Color.Silver;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderSize = 1;
            roundedPanel1.Controls.Add(TxtPassword);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(linkLabel1);
            roundedPanel1.Controls.Add(BtnLogin);
            roundedPanel1.Controls.Add(TxtUser);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Location = new System.Drawing.Point(363, 75);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new System.Drawing.Size(494, 449);
            roundedPanel1.TabIndex = 8;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1251, 631);
            Controls.Add(roundedPanel1);
            Text = "LogIn";
            Load += LogIn_Load;
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnLogin;
        private TextBox TxtUser;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.TextBox TxtPassword;
        private LinkLabel linkLabel1;
        private Label label4;
        private Util.RoundedPanel roundedPanel1;
    }
}