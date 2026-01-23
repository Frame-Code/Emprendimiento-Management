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
            pbFoto = new PictureBox();
            btnGuardar = new Button();
            txtComentario = new TextBox();
            flpFotos = new FlowLayoutPanel();
            label1 = new Label();
            dgvComentarios = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).BeginInit();
            SuspendLayout();
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(160, 363);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(132, 94);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.Location = new Point(397, 534);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Comentar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtComentario
            // 
            txtComentario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtComentario.Location = new Point(21, 472);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(507, 37);
            txtComentario.TabIndex = 3;
            // 
            // flpFotos
            // 
            flpFotos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpFotos.AutoScroll = true;
            flpFotos.Location = new Point(21, 37);
            flpFotos.Name = "flpFotos";
            flpFotos.Size = new Size(507, 309);
            flpFotos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 577);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Comentarios";
            // 
            // dgvComentarios
            // 
            dgvComentarios.AllowUserToAddRows = false;
            dgvComentarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvComentarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComentarios.BackgroundColor = Color.White;
            dgvComentarios.BorderStyle = BorderStyle.None;
            dgvComentarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvComentarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComentarios.Location = new Point(21, 607);
            dgvComentarios.MultiSelect = false;
            dgvComentarios.Name = "dgvComentarios";
            dgvComentarios.ReadOnly = true;
            dgvComentarios.RowHeadersVisible = false;
            dgvComentarios.ScrollBars = ScrollBars.Horizontal;
            dgvComentarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComentarios.Size = new Size(507, 178);
            dgvComentarios.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 12);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 8;
            label2.Text = "Galeria";
            // 
            // GaleriaEmprendimientoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(dgvComentarios);
            Controls.Add(label1);
            Controls.Add(flpFotos);
            Controls.Add(txtComentario);
            Controls.Add(btnGuardar);
            Controls.Add(pbFoto);
            Name = "GaleriaEmprendimientoView";
            Size = new Size(663, 808);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFoto;
        private Button btnGuardar;
        private TextBox txtComentario;
        private FlowLayoutPanel flpFotos;
        private Label label1;
        private DataGridView dgvComentarios;
        private Label label2;
    }
}