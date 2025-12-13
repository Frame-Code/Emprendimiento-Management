namespace WinForms.Views.Util
{
    partial class VerParticipantesView
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
            dgvParticipantes = new DataGridView();
            label2 = new Label();
            btnRegistrate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(529, 48);
            label1.TabIndex = 0;
            label1.Text = "Participantes Emprendimiento";
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Location = new Point(12, 60);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.RowHeadersWidth = 62;
            dgvParticipantes.Size = new Size(810, 371);
            dgvParticipantes.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 446);
            label2.Name = "label2";
            label2.Size = new Size(207, 30);
            label2.TabIndex = 2;
            label2.Text = "Registrate GRATIS!";
            // 
            // btnRegistrate
            // 
            btnRegistrate.Location = new Point(225, 437);
            btnRegistrate.Name = "btnRegistrate";
            btnRegistrate.Size = new Size(159, 50);
            btnRegistrate.TabIndex = 3;
            btnRegistrate.Text = "Registrate";
            btnRegistrate.UseVisualStyleBackColor = true;
            btnRegistrate.Click += btnRegistrate_Click;
            // 
            // VerParticipantesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRegistrate);
            Controls.Add(label2);
            Controls.Add(dgvParticipantes);
            Controls.Add(label1);
            Name = "VerParticipantesView";
            Size = new Size(859, 496);
            Load += VerParticipantesView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvParticipantes;
        private Label label2;
        private Button btnRegistrate;
    }
}