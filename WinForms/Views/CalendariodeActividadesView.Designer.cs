namespace WinForms.Views
{
    partial class CalendariodeActividadesView
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            dgvActividades = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            BtnFiltrar = new Button();
            cmbFacultad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(3, 1);
            monthCalendar1.Location = new Point(18, 44);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(231, 5);
            label1.Name = "label1";
            label1.Size = new Size(267, 30);
            label1.TabIndex = 1;
            label1.Text = "Calendario de Actividades";
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new Point(265, 235);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.ReadOnly = true;
            dgvActividades.Size = new Size(442, 158);
            dgvActividades.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 278);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 6;
            label3.Text = "Selecciona tu Facultad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 235);
            label4.Name = "label4";
            label4.Size = new Size(71, 30);
            label4.TabIndex = 9;
            label4.Text = "Filtro ";
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Location = new Point(30, 337);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new Size(100, 31);
            BtnFiltrar.TabIndex = 10;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = true;
            BtnFiltrar.Click += BtnFiltrar_Click;
            // 
            // cmbFacultad
            // 
            cmbFacultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFacultad.FormattingEnabled = true;
            cmbFacultad.Location = new Point(30, 296);
            cmbFacultad.Name = "cmbFacultad";
            cmbFacultad.Size = new Size(195, 23);
            cmbFacultad.TabIndex = 11;
            cmbFacultad.SelectedIndexChanged += cmbFacultad_SelectedIndexChanged;
            // 
            // CalendariodeActividadesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 411);
            Controls.Add(cmbFacultad);
            Controls.Add(BtnFiltrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvActividades);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "CalendariodeActividadesView";
            Text = "CalendariodeActividadesView";
            Load += CalendariodeActividadesView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private DataGridView dgvActividades;
        private Label label3;
        private Label label4;
        private Button BtnFiltrar;
        private ComboBox cmbFacultad;
    }
}