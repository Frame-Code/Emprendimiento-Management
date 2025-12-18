namespace WinForms.Views.UserControls
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
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            label1 = new System.Windows.Forms.Label();
            dgvActividades = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            BtnFiltrar = new System.Windows.Forms.Button();
            cmbFacultad = new System.Windows.Forms.ComboBox();
            BtnCrearEvento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new System.Drawing.Size(4, 1);
            monthCalendar1.Location = new System.Drawing.Point(26, 84);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(367, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(352, 37);
            label1.TabIndex = 1;
            label1.Text = "Calendario de Actividades";
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new System.Drawing.Point(26, 362);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowHeadersWidth = 51;
            dgvActividades.Size = new System.Drawing.Size(1060, 335);
            dgvActividades.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 318);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(218, 20);
            label3.TabIndex = 6;
            label3.Text = "Selecciona una facultad a filtrar";
            // 
            // BtnFiltrar
            // 
            BtnFiltrar.Location = new System.Drawing.Point(857, 303);
            BtnFiltrar.Name = "BtnFiltrar";
            BtnFiltrar.Size = new System.Drawing.Size(229, 35);
            BtnFiltrar.TabIndex = 10;
            BtnFiltrar.Text = "Filtrar";
            BtnFiltrar.UseVisualStyleBackColor = true;
            BtnFiltrar.Click += BtnFiltrar_Click;
            // 
            // cmbFacultad
            // 
            cmbFacultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFacultad.FormattingEnabled = true;
            cmbFacultad.Location = new System.Drawing.Point(326, 310);
            cmbFacultad.Name = "cmbFacultad";
            cmbFacultad.Size = new System.Drawing.Size(500, 28);
            cmbFacultad.TabIndex = 11;
            cmbFacultad.SelectedIndexChanged += cmbFacultad_SelectedIndexChanged;
            // 
            // BtnCrearEvento
            // 
            BtnCrearEvento.Location = new System.Drawing.Point(162, 722);
            BtnCrearEvento.Name = "BtnCrearEvento";
            BtnCrearEvento.Size = new System.Drawing.Size(763, 41);
            BtnCrearEvento.TabIndex = 12;
            BtnCrearEvento.Text = "Crear nuevo evento";
            BtnCrearEvento.UseVisualStyleBackColor = true;
            BtnCrearEvento.Click += BtnCrearEvento_Click;
            // 
            // CalendariodeActividadesView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(BtnCrearEvento);
            Controls.Add(cmbFacultad);
            Controls.Add(BtnFiltrar);
            Controls.Add(label3);
            Controls.Add(dgvActividades);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Size = new System.Drawing.Size(1183, 786);
            Load += CalendariodeActividadesView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button BtnCrearEvento;

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.ComboBox cmbFacultad;
    }
}