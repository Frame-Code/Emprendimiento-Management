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
            panel1.Controls.Add(LblUserName);
            panel1.Controls.Add(btnEmprendimientoReg);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 79);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 639);
            panel1.TabIndex = 0;
            // 
            // LblUserName
            // 
            LblUserName.AutoSize = true;
            LblUserName.Font = new Font("Segoe UI", 13F);
            LblUserName.Location = new Point(11, 45);
            LblUserName.Name = "LblUserName";
            LblUserName.Size = new Size(122, 30);
            LblUserName.TabIndex = 0;
            LblUserName.Text = "Useraname";
            // 
            // btnEmprendimientoReg
            // 
            btnEmprendimientoReg.BackColor = Color.LightGray;
            btnEmprendimientoReg.Location = new Point(38, 127);
            btnEmprendimientoReg.Margin = new Padding(3, 4, 3, 4);
            btnEmprendimientoReg.Name = "btnEmprendimientoReg";
            btnEmprendimientoReg.Size = new Size(153, 80);
            btnEmprendimientoReg.TabIndex = 1;
            btnEmprendimientoReg.Text = "Consultar Emprendimientos\r\nRegistrados";
            btnEmprendimientoReg.UseVisualStyleBackColor = false;
            btnEmprendimientoReg.Click += btnEmprendimientoReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 75);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 0;
            label1.Text = "______________________________________";
            // 
            // pnlContenedorModuloEst
            // 
            pnlContenedorModuloEst.BorderStyle = BorderStyle.FixedSingle;
            pnlContenedorModuloEst.Location = new Point(240, 79);
            pnlContenedorModuloEst.Margin = new Padding(3, 4, 3, 4);
            pnlContenedorModuloEst.Name = "pnlContenedorModuloEst";
            pnlContenedorModuloEst.Size = new Size(898, 639);
            pnlContenedorModuloEst.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1138, 85);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 23);
            label2.Name = "label2";
            label2.Size = new Size(299, 37);
            label2.TabIndex = 0;
            label2.Text = "Modulo de Estudiante";
            // 
            // MainEstudianteView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 717);
            Controls.Add(panel3);
            Controls.Add(pnlContenedorModuloEst);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}