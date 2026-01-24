namespace WinForms.Views.UserControls
{
    partial class GaleriaEmprendimientoView
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
            btnGuardar = new System.Windows.Forms.Button();
            txtComentario = new System.Windows.Forms.TextBox();
            flpFotos = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            dgvComentarios = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            BtnBuscarEmprendmiento = new System.Windows.Forms.Button();
            CmbEmprendimientos = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnGuardar.Location = new System.Drawing.Point(3287, 534);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(131, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Comentar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtComentario
            // 
            txtComentario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            txtComentario.Location = new System.Drawing.Point(21, 476);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.PlaceholderText = "Agrega un comentario de este emprendimiento";
            txtComentario.Size = new System.Drawing.Size(955, 37);
            txtComentario.TabIndex = 3;
            // 
            // flpFotos
            // 
            flpFotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            flpFotos.AutoScroll = true;
            flpFotos.Location = new System.Drawing.Point(21, 96);
            flpFotos.Name = "flpFotos";
            flpFotos.Size = new System.Drawing.Size(1258, 321);
            flpFotos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 441);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 20);
            label1.TabIndex = 6;
            label1.Text = "Comentarios";
            // 
            // dgvComentarios
            // 
            dgvComentarios.AllowUserToAddRows = false;
            dgvComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            dgvComentarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvComentarios.BackgroundColor = System.Drawing.Color.White;
            dgvComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvComentarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComentarios.Location = new System.Drawing.Point(23, 533);
            dgvComentarios.MultiSelect = false;
            dgvComentarios.Name = "dgvComentarios";
            dgvComentarios.ReadOnly = true;
            dgvComentarios.RowHeadersVisible = false;
            dgvComentarios.RowHeadersWidth = 51;
            dgvComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            dgvComentarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvComentarios.Size = new System.Drawing.Size(1256, 246);
            dgvComentarios.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.Location = new System.Drawing.Point(1606, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 27);
            label2.TabIndex = 8;
            label2.Text = "Galeria";
            // 
            // BtnBuscarEmprendmiento
            // 
            BtnBuscarEmprendmiento.Location = new System.Drawing.Point(1100, 52);
            BtnBuscarEmprendmiento.Name = "BtnBuscarEmprendmiento";
            BtnBuscarEmprendmiento.Size = new System.Drawing.Size(179, 35);
            BtnBuscarEmprendmiento.TabIndex = 10;
            BtnBuscarEmprendmiento.Text = "Buscar emprendimiento";
            BtnBuscarEmprendmiento.UseVisualStyleBackColor = true;
            BtnBuscarEmprendmiento.Click += BtnBuscarEmprendimiento_Click;
            // 
            // CmbEmprendimientos
            // 
            CmbEmprendimientos.FormattingEnabled = true;
            CmbEmprendimientos.Location = new System.Drawing.Point(21, 59);
            CmbEmprendimientos.Name = "CmbEmprendimientos";
            CmbEmprendimientos.Size = new System.Drawing.Size(785, 28);
            CmbEmprendimientos.TabIndex = 11;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(23, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(559, 21);
            label3.TabIndex = 12;
            label3.Text = "Selecciona un emprendimiento para ver su galeria de fotos";
            // 
            // GaleriaEmprendimientoView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(CmbEmprendimientos);
            Controls.Add(BtnBuscarEmprendmiento);
            Controls.Add(label2);
            Controls.Add(dgvComentarios);
            Controls.Add(label1);
            Controls.Add(flpFotos);
            Controls.Add(txtComentario);
            Controls.Add(btnGuardar);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Size = new System.Drawing.Size(1333, 808);
            Load += GaleriaEmprendimientoView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button BtnBuscarEmprendmiento;
        private System.Windows.Forms.ComboBox CmbEmprendimientos;
        private System.Windows.Forms.Label label3;

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.FlowLayoutPanel flpFotos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvComentarios;
        private System.Windows.Forms.Label label2;
    }
}