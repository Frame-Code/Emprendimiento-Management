namespace WinForms.Views
{
    partial class MainEstudianteView
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
            LblUserName = new Label();
            btnEmprendimientoReg = new Button();
            pnlContenedorModuloEst = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            roundedPanel2 = new WinForms.Views.Util.RoundedPanel();
            roundedPanel1 = new WinForms.Views.Util.RoundedPanel();


            btnGaleria = new Button();

            BtnVotarView = new Button();
            BotonCalendario = new Button();

            panel3.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Segoe UI", 13F);
            LblUserName.Location = new Point(25, 18);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(100, 25);
            LblUserName.TabIndex = 0;
            LblUserName.Text = "Useraname";
            // 
            // btnEmprendimientoReg
            // 
            btnEmprendimientoReg.BackColor = Color.LightGray;
            btnEmprendimientoReg.Location = new Point(11, 16);

            btnEmprendimientoReg.Name = "btnEmprendimientoReg";
            btnEmprendimientoReg.Size = new Size(234, 39);
            btnEmprendimientoReg.TabIndex = 1;
            btnEmprendimientoReg.Text = "Consultar Emprendimientos\r\n";
            btnEmprendimientoReg.UseVisualStyleBackColor = false;
            btnEmprendimientoReg.Click += btnEmprendimientoReg_Click;
            // 
            // pnlContenedorModuloEst
            // 
            pnlContenedorModuloEst.BackColor = SystemColors.ButtonHighlight;
            pnlContenedorModuloEst.Location = new Point(279, 40);
            pnlContenedorModuloEst.Name = "pnlContenedorModuloEst";

            pnlContenedorModuloEst.Size = new Size(1363, 640);
            pnlContenedorModuloEst.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 7);
            label2.Name = "label2";
            label2.Size = new Size(407, 30);
            label2.TabIndex = 0;
            label2.Text = "Sistema de gestión de emprendimientos";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1642, 40);

            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";

            panel1.Size = new Size(280, 621);

            panel1.TabIndex = 3;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.FromArgb(250, 250, 250);
            roundedPanel2.BorderColor = Color.LightGray;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderSize = 1;
            roundedPanel2.Controls.Add(LblUserName);
            roundedPanel2.Dock = DockStyle.Bottom;

            roundedPanel2.Location = new Point(0, 574);

            roundedPanel2.Margin = new Padding(3, 2, 3, 2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(280, 47);
            roundedPanel2.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(250, 250, 250);
            roundedPanel1.BorderColor = Color.LightGray;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderSize = 1;

            roundedPanel1.Controls.Add(btnGaleria);

            roundedPanel1.Controls.Add(BotonCalendario);

            roundedPanel1.Controls.Add(BtnVotarView);

            roundedPanel1.Controls.Add(btnEmprendimientoReg);
            roundedPanel1.Location = new Point(10, 5);
            roundedPanel1.Margin = new Padding(3, 2, 3, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(263, 538);
            roundedPanel1.TabIndex = 0;
            // 

            // btnGaleria
            // 
            btnGaleria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGaleria.Location = new Point(15, 81);
            btnGaleria.Name = "btnGaleria";
            btnGaleria.Size = new Size(234, 37);
            btnGaleria.TabIndex = 2;
            btnGaleria.Text = "ver galeria";
            btnGaleria.UseVisualStyleBackColor = true;
            btnGaleria.Click += btnGaleria_Click;

            // BtnVotarView
            // 
            BtnVotarView.BackColor = Color.LightGray;
            BtnVotarView.Location = new Point(11, 78);
            BtnVotarView.Name = "BtnVotarView";
            BtnVotarView.Size = new Size(234, 39);
            BtnVotarView.TabIndex = 2;
            BtnVotarView.Text = "Votar emprendimiento favorito";
            BtnVotarView.UseVisualStyleBackColor = false;
            BtnVotarView.Click += BtnVotarView_Click;

            // 
            // BotonCalendario
            // 
            BotonCalendario.Location = new Point(11, 133);
            BotonCalendario.Name = "BotonCalendario";
            BotonCalendario.Size = new Size(238, 39);
            BotonCalendario.TabIndex = 3;
            BotonCalendario.Text = "Calendario";
            BotonCalendario.UseVisualStyleBackColor = true;
            BotonCalendario.Click += BotonCalendario_Click;
            // 
            // MainEstudianteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1404, 661);

            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(pnlContenedorModuloEst);
            Name = "MainEstudianteView";
            Text = "MainEstudianteView";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            roundedPanel2.ResumeLayout(false);
            roundedPanel2.PerformLayout();
            roundedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button BtnVotarView;

        private WinForms.Views.Util.RoundedPanel roundedPanel1;
        private WinForms.Views.Util.RoundedPanel roundedPanel2;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.Panel pnlContenedorModuloEst;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmprendimientoReg;
        private System.Windows.Forms.Label LblUserName;

        private Button btnGaleria;

        private Button BotonCalendario;

    }
}