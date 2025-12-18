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
            btnGaleria = new Button();
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
            panel1.Controls.Add(btnGaleria);
            panel1.Controls.Add(LblUserName);
            panel1.Controls.Add(btnEmprendimientoReg);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 99);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 798);
            panel1.TabIndex = 0;
            // 
            // btnGaleria
            // 
            btnGaleria.BackColor = Color.LightGray;
            btnGaleria.Location = new Point(48, 585);
            btnGaleria.Margin = new Padding(4, 5, 4, 5);
            btnGaleria.Name = "btnGaleria";
            btnGaleria.Size = new Size(191, 100);
            btnGaleria.TabIndex = 2;
            btnGaleria.Text = "Galeria";
            btnGaleria.UseVisualStyleBackColor = false;
            btnGaleria.Click += btnGaleria_Click;
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Segoe UI", 13F);
            LblUserName.Location = new Point(14, 56);
            LblUserName.Margin = new Padding(4, 0, 4, 0);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(144, 36);
            LblUserName.TabIndex = 0;
            LblUserName.Text = "Useraname";
            // 
            // btnEmprendimientoReg
            // 
            btnEmprendimientoReg.BackColor = Color.LightGray;
            btnEmprendimientoReg.Location = new Point(48, 159);
            btnEmprendimientoReg.Margin = new Padding(4, 5, 4, 5);
            btnEmprendimientoReg.Name = "btnEmprendimientoReg";
            btnEmprendimientoReg.Size = new Size(191, 100);
            btnEmprendimientoReg.TabIndex = 1;
            btnEmprendimientoReg.Text = "Consultar Emprendimientos\r\nRegistrados";
            btnEmprendimientoReg.UseVisualStyleBackColor = false;
            btnEmprendimientoReg.Click += btnEmprendimientoReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(278, 25);
            label1.TabIndex = 0;
            label1.Text = "______________________________________";
            // 
            // pnlContenedorModuloEst
            // 
            pnlContenedorModuloEst.BorderStyle = BorderStyle.FixedSingle;
            pnlContenedorModuloEst.Location = new Point(300, 99);
            pnlContenedorModuloEst.Margin = new Padding(4, 5, 4, 5);
            pnlContenedorModuloEst.Name = "pnlContenedorModuloEst";
            pnlContenedorModuloEst.Size = new Size(1122, 798);
            pnlContenedorModuloEst.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1422, 106);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(350, 45);
            label2.TabIndex = 0;
            label2.Text = "Modulo de Estudiante";
            // 
            // MainEstudianteView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 896);
            Controls.Add(panel3);
            Controls.Add(pnlContenedorModuloEst);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnGaleria;
    }
}