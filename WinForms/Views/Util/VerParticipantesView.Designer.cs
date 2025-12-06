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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            btnRegistrate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(529, 48);
            label1.TabIndex = 0;
            label1.Text = "Participantes Emprendimiento";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(394, 318);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(501, 183);
            label2.Name = "label2";
            label2.Size = new Size(474, 38);
            label2.TabIndex = 2;
            label2.Text = "No te has registrado? , Hazlo abajo";
            // 
            // btnRegistrate
            // 
            btnRegistrate.Location = new Point(552, 252);
            btnRegistrate.Name = "btnRegistrate";
            btnRegistrate.Size = new Size(362, 65);
            btnRegistrate.TabIndex = 3;
            btnRegistrate.Text = "Registrate";
            btnRegistrate.UseVisualStyleBackColor = true;
            btnRegistrate.Click += btnRegistrate_Click;
            // 
            // VerParticipantesView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 450);
            Controls.Add(btnRegistrate);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "VerParticipantesView";
            Text = "VerParticipantesView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btnRegistrate;
    }
}