namespace WinForms.Views
{
    partial class GestionAgendaView
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
            label6 = new Label();
            label5 = new Label();
            btnAgregarPresentacion = new Button();
            cmbExpositor = new ComboBox();
            groupBox2 = new GroupBox();
            cmbEvento = new ComboBox();
            label1 = new Label();
            dgAgenda = new DataGridView();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAgenda).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(306, 29);
            label6.Name = "label6";
            label6.Size = new Size(317, 32);
            label6.TabIndex = 2;
            label6.Text = "Gestion de Agendamiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(29, 106);
            label5.Name = "label5";
            label5.Size = new Size(74, 18);
            label5.TabIndex = 4;
            label5.Text = "Expositor";
            // 
            // btnAgregarPresentacion
            // 
            btnAgregarPresentacion.BackColor = Color.LightBlue;
            btnAgregarPresentacion.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPresentacion.Location = new Point(95, 172);
            btnAgregarPresentacion.Name = "btnAgregarPresentacion";
            btnAgregarPresentacion.Size = new Size(94, 39);
            btnAgregarPresentacion.TabIndex = 8;
            btnAgregarPresentacion.Text = "Agendar";
            btnAgregarPresentacion.UseVisualStyleBackColor = false;
            btnAgregarPresentacion.Click += btnAgregarPresentacion_Click;
            // 
            // cmbExpositor
            // 
            cmbExpositor.BackColor = SystemColors.GradientActiveCaption;
            cmbExpositor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbExpositor.FormattingEnabled = true;
            cmbExpositor.Location = new Point(128, 106);
            cmbExpositor.Name = "cmbExpositor";
            cmbExpositor.Size = new Size(140, 28);
            cmbExpositor.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(cmbEvento);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbExpositor);
            groupBox2.Controls.Add(btnAgregarPresentacion);
            groupBox2.Controls.Add(label5);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(54, 114);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(352, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agendamiento";
            // 
            // cmbEvento
            // 
            cmbEvento.BackColor = SystemColors.GradientActiveCaption;
            cmbEvento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEvento.FormattingEnabled = true;
            cmbEvento.Location = new Point(129, 52);
            cmbEvento.Name = "cmbEvento";
            cmbEvento.Size = new Size(139, 28);
            cmbEvento.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(29, 56);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 10;
            label1.Text = "Evento";
            // 
            // dgAgenda
            // 
            dgAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAgenda.Location = new Point(490, 151);
            dgAgenda.Name = "dgAgenda";
            dgAgenda.Size = new Size(240, 150);
            dgAgenda.TabIndex = 3;
            // 
            // GestionAgendaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 499);
            Controls.Add(dgAgenda);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Name = "GestionAgendaView";
            Text = "GestionAgendaView";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Button btnAgregarPresentacion;
        private ComboBox cmbExpositor;
        private GroupBox groupBox2;
        private ComboBox cmbEvento;
        private Label label1;
        private DataGridView dgAgenda;
    }
}