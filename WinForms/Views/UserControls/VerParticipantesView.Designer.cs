namespace WinForms.Views.UserControls
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
            label1 = new System.Windows.Forms.Label();
            dgvParticipantes = new System.Windows.Forms.DataGridView();
            btnRegistrate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(369, 41);
            label1.TabIndex = 0;
            label1.Text = "Participantes registrados";
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Location = new System.Drawing.Point(12, 60);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.RowHeadersWidth = 62;
            dgvParticipantes.Size = new System.Drawing.Size(1088, 442);
            dgvParticipantes.TabIndex = 1;
            // 
            // btnRegistrate
            // 
            btnRegistrate.Location = new System.Drawing.Point(128, 526);
            btnRegistrate.Name = "btnRegistrate";
            btnRegistrate.Size = new System.Drawing.Size(844, 44);
            btnRegistrate.TabIndex = 3;
            btnRegistrate.Text = "Registrar nuevo participante";
            btnRegistrate.UseVisualStyleBackColor = true;
            btnRegistrate.Click += btnRegistrate_Click;
            // 
            // VerParticipantesView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnRegistrate);
            Controls.Add(dgvParticipantes);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Size = new System.Drawing.Size(1125, 768);
            Load += VerParticipantesView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.Button btnRegistrate;
    }
}