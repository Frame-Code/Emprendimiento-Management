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
            dataGridView1 = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Facultad = new DataGridViewTextBoxColumn();
            Actividades = new DataGridViewTextBoxColumn();
            label2 = new Label();
            CmbFacultad = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            BtnFiltrar_click = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(4, 3);
            monthCalendar1.Location = new Point(68, 52);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 13);
            label1.Name = "label1";
            label1.Size = new Size(267, 30);
            label1.TabIndex = 1;
            label1.Text = "Calendario de Actividades";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Hora, Facultad, Actividades });
            dataGridView1.Location = new Point(356, 520);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(648, 158);
            dataGridView1.TabIndex = 2;
            // 
            // Hora
            // 
            Hora.HeaderText = "Hora";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            // 
            // Facultad
            // 
            Facultad.HeaderText = "Facultad";
            Facultad.Name = "Facultad";
            // 
            // Actividades
            // 
            Actividades.HeaderText = "Actividades";
            Actividades.Name = "Actividades";
            Actividades.Width = 500;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 517);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 3;
            label2.Text = "Filtro ";
            label2.Click += label2_Click;
            // 
            // CmbFacultad
            // 
            CmbFacultad.FormattingEnabled = true;
            CmbFacultad.Location = new Point(105, 581);
            CmbFacultad.Name = "CmbFacultad";
            CmbFacultad.Size = new Size(208, 23);
            CmbFacultad.TabIndex = 4;
            CmbFacultad.SelectedIndexChanged += CmbFacultad_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 563);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 6;
            label3.Text = "Selecciona tu Facultad";
            // 
            // BtnFiltrar_click
            // 
            BtnFiltrar_click.Location = new Point(147, 627);
            BtnFiltrar_click.Name = "BtnFiltrar_click";
            BtnFiltrar_click.Size = new Size(100, 31);
            BtnFiltrar_click.TabIndex = 8;
            BtnFiltrar_click.Text = "Filtrar";
            BtnFiltrar_click.UseVisualStyleBackColor = true;
            BtnFiltrar_click.Click += BtnFiltrar_click_Click;
            // 
            // CalendariodeActividadesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 723);
            Controls.Add(BtnFiltrar_click);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(CmbFacultad);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "CalendariodeActividadesView";
            Text = "CalendariodeActividadesView";
            Load += CalendariodeActividadesView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Facultad;
        private DataGridViewTextBoxColumn Actividades;
        private ComboBox CmbFacultad;
        private Button button1;
        private Label label3;
        private Button BtnFiltrar_click;
    }
}