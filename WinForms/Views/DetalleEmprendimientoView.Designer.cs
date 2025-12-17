namespace WinForms
{
    partial class DetalleEmprendimientoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleEmprendimientoView));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            LblNombre = new System.Windows.Forms.Label();
            LblFacultad = new System.Windows.Forms.Label();
            LblRubro = new System.Windows.Forms.Label();
            LblDescripcion = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            LblParticipantes = new System.Windows.Forms.Label();
            BtnNuevoParticipante = new System.Windows.Forms.Button();
            GridParticipantes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridParticipantes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(464, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(346, 35);
            label1.TabIndex = 0;
            label1.Text = "Detalle del emprendimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(78, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(545, 134);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(78, 134);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(76, 20);
            label4.TabIndex = 4;
            label4.Text = "Facultad: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(545, 88);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(56, 20);
            label5.TabIndex = 5;
            label5.Text = "Rubro:";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Location = new System.Drawing.Point(155, 88);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new System.Drawing.Size(18, 20);
            LblNombre.TabIndex = 7;
            LblNombre.Text = "...";
            // 
            // LblFacultad
            // 
            LblFacultad.AutoSize = true;
            LblFacultad.Location = new System.Drawing.Point(155, 134);
            LblFacultad.Name = "LblFacultad";
            LblFacultad.Size = new System.Drawing.Size(18, 20);
            LblFacultad.TabIndex = 8;
            LblFacultad.Text = "...";
            // 
            // LblRubro
            // 
            LblRubro.AutoSize = true;
            LblRubro.Location = new System.Drawing.Point(603, 88);
            LblRubro.Name = "LblRubro";
            LblRubro.Size = new System.Drawing.Size(18, 20);
            LblRubro.TabIndex = 9;
            LblRubro.Text = "...";
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.Location = new System.Drawing.Point(641, 134);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new System.Drawing.Size(18, 20);
            LblDescripcion.TabIndex = 10;
            LblDescripcion.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(78, 182);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(913, 20);
            label8.TabIndex = 13;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label11.Location = new System.Drawing.Point(78, 545);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(162, 20);
            label11.TabIndex = 20;
            label11.Text = "Lista de participantes:";
            // 
            // LblParticipantes
            // 
            LblParticipantes.AutoSize = true;
            LblParticipantes.Location = new System.Drawing.Point(78, 582);
            LblParticipantes.Name = "LblParticipantes";
            LblParticipantes.Size = new System.Drawing.Size(18, 20);
            LblParticipantes.TabIndex = 21;
            LblParticipantes.Text = "...";
            // 
            // BtnNuevoParticipante
            // 
            BtnNuevoParticipante.Location = new System.Drawing.Point(232, 496);
            BtnNuevoParticipante.Name = "BtnNuevoParticipante";
            BtnNuevoParticipante.Size = new System.Drawing.Size(652, 34);
            BtnNuevoParticipante.TabIndex = 22;
            BtnNuevoParticipante.Text = "Nuevo participante";
            BtnNuevoParticipante.UseVisualStyleBackColor = true;
            BtnNuevoParticipante.Click += BtnNuevoParticipante_Click;
            // 
            // GridParticipantes
            // 
            GridParticipantes.ColumnHeadersHeight = 29;
            GridParticipantes.Location = new System.Drawing.Point(78, 218);
            GridParticipantes.Name = "GridParticipantes";
            GridParticipantes.RowHeadersWidth = 51;
            GridParticipantes.Size = new System.Drawing.Size(1141, 254);
            GridParticipantes.TabIndex = 23;
            GridParticipantes.CellContentClick += GridParticipantes_CellContentClick;
            // 
            // DetalleEmprendimientoView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1245, 872);
            Controls.Add(GridParticipantes);
            Controls.Add(BtnNuevoParticipante);
            Controls.Add(LblParticipantes);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(LblDescripcion);
            Controls.Add(LblRubro);
            Controls.Add(LblFacultad);
            Controls.Add(LblNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Text = "DetalleEmprendimientoView";
            Load += DetalleEmprendimientoView_Load;
            ((System.ComponentModel.ISupportInitialize)GridParticipantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button BtnNuevoParticipante;
        private System.Windows.Forms.DataGridView GridParticipantes;

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label LblNombre;
        private Label LblFacultad;
        private Label LblRubro;
        private Label LblDescripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblParticipantes;
    }
}