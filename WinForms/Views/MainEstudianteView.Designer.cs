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
            panel1 = new Panel();
            BtnCalendarioInsano = new Button();
            LblUserName = new Label();
            btnEmprendimientoReg = new Button();
            label1 = new Label();
            pnlContenedorModuloEst = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(BtnCalendarioInsano);
            panel1.Controls.Add(LblUserName);
            panel1.Controls.Add(btnEmprendimientoReg);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 480);
            panel1.TabIndex = 0;
            // 
            // BtnCalendarioInsano
            // 
            BtnCalendarioInsano.Location = new Point(33, 172);
            BtnCalendarioInsano.Name = "BtnCalendarioInsano";
            BtnCalendarioInsano.Size = new Size(130, 55);
            BtnCalendarioInsano.TabIndex = 2;
            BtnCalendarioInsano.Text = "Evento";
            BtnCalendarioInsano.UseVisualStyleBackColor = true;
            BtnCalendarioInsano.Click += BtnCalendarioInsano_Click;
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Segoe UI", 13F);
            LblUserName.Location = new Point(10, 34);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(100, 25);
            LblUserName.TabIndex = 0;
            LblUserName.Text = "Useraname";
            // 
            // btnEmprendimientoReg
            // 
            btnEmprendimientoReg.BackColor = Color.LightGray;
            btnEmprendimientoReg.Location = new Point(33, 95);
            btnEmprendimientoReg.Name = "btnEmprendimientoReg";
            btnEmprendimientoReg.Size = new Size(134, 60);
            btnEmprendimientoReg.TabIndex = 1;
            btnEmprendimientoReg.Text = "Consultar Emprendimientos\r\nRegistrados";
            btnEmprendimientoReg.UseVisualStyleBackColor = false;
            btnEmprendimientoReg.Click += btnEmprendimientoReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 56);
            label1.Name = "label1";
            label1.Size = new Size(197, 15);
            label1.TabIndex = 0;
            label1.Text = "______________________________________";
            // 
            // pnlContenedorModuloEst
            // 
            pnlContenedorModuloEst.BorderStyle = BorderStyle.Fixed3D;
            pnlContenedorModuloEst.Location = new Point(210, 59);
            pnlContenedorModuloEst.Name = "pnlContenedorModuloEst";
            pnlContenedorModuloEst.Size = new Size(786, 480);
            pnlContenedorModuloEst.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(996, 64);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 17);
            label2.Name = "label2";
            label2.Size = new Size(230, 30);
            label2.TabIndex = 0;
            label2.Text = "Modulo de Estudiante";
            // 
            // MainEstudianteView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 538);
            Controls.Add(panel3);
            Controls.Add(pnlContenedorModuloEst);
            Controls.Add(panel1);
            Name = "MainEstudianteView";
            Text = "MainEstudianteView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel pnlContenedorModuloEst;
        private Panel panel3;
        private Label label2;
        private Button btnEmprendimientoReg;
        private Label LblUserName;
        private Button BtnCalendarioInsano;
    }
}