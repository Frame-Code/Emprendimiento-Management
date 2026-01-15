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
            LblUserName = new System.Windows.Forms.Label();
            btnEmprendimientoReg = new System.Windows.Forms.Button();
            pnlContenedorModuloEst = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            roundedPanel2 = new WinForms.Views.Util.RoundedPanel();
            roundedPanel1 = new WinForms.Views.Util.RoundedPanel();
            BtnVotarView = new System.Windows.Forms.Button();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            roundedPanel2.SuspendLayout();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new System.Drawing.Font("Segoe UI", 13F);
            LblUserName.Location = new System.Drawing.Point(29, 24);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new System.Drawing.Size(122, 30);
            LblUserName.TabIndex = 0;
            LblUserName.Text = "Useraname";
            // 
            // btnEmprendimientoReg
            // 
            btnEmprendimientoReg.BackColor = System.Drawing.Color.LightGray;
            btnEmprendimientoReg.Location = new System.Drawing.Point(13, 21);
            btnEmprendimientoReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEmprendimientoReg.Name = "btnEmprendimientoReg";
            btnEmprendimientoReg.Size = new System.Drawing.Size(267, 52);
            btnEmprendimientoReg.TabIndex = 1;
            btnEmprendimientoReg.Text = "Consultar Emprendimientos\r\n";
            btnEmprendimientoReg.UseVisualStyleBackColor = false;
            btnEmprendimientoReg.Click += btnEmprendimientoReg_Click;
            // 
            // pnlContenedorModuloEst
            // 
            pnlContenedorModuloEst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            pnlContenedorModuloEst.Location = new System.Drawing.Point(319, 53);
            pnlContenedorModuloEst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlContenedorModuloEst.Name = "pnlContenedorModuloEst";
            pnlContenedorModuloEst.Size = new System.Drawing.Size(1558, 854);
            pnlContenedorModuloEst.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(29, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(534, 37);
            label2.TabIndex = 0;
            label2.Text = "Sistema de gestión de emprendimientos";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            panel3.Controls.Add(label2);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1877, 53);
            panel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            panel1.Controls.Add(roundedPanel2);
            panel1.Controls.Add(roundedPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(320, 854);
            panel1.TabIndex = 3;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
            roundedPanel2.BorderColor = System.Drawing.Color.LightGray;
            roundedPanel2.BorderRadius = 20;
            roundedPanel2.BorderSize = 1;
            roundedPanel2.Controls.Add(LblUserName);
            roundedPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            roundedPanel2.Location = new System.Drawing.Point(0, 791);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new System.Drawing.Size(320, 63);
            roundedPanel2.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
            roundedPanel1.BorderColor = System.Drawing.Color.LightGray;
            roundedPanel1.BorderRadius = 20;
            roundedPanel1.BorderSize = 1;
            roundedPanel1.Controls.Add(BtnVotarView);
            roundedPanel1.Controls.Add(btnEmprendimientoReg);
            roundedPanel1.Location = new System.Drawing.Point(12, 7);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new System.Drawing.Size(301, 717);
            roundedPanel1.TabIndex = 0;
            // 
            // BtnVotarView
            // 
            BtnVotarView.BackColor = System.Drawing.Color.LightGray;
            BtnVotarView.Location = new System.Drawing.Point(13, 104);
            BtnVotarView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnVotarView.Name = "BtnVotarView";
            BtnVotarView.Size = new System.Drawing.Size(267, 52);
            BtnVotarView.TabIndex = 2;
            BtnVotarView.Text = "Votar emprendimiento favorito";
            BtnVotarView.UseVisualStyleBackColor = false;
            BtnVotarView.Click += BtnVotarView_Click;
            // 
            // MainEstudianteView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1877, 907);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(pnlContenedorModuloEst);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}