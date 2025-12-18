namespace WinForms.Views
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
            pnlGene = new Panel();
            btnComentar = new Button();
            txtComentario = new TextBox();
            pictureBox1 = new PictureBox();
            flpAlbumFotos = new FlowLayoutPanel();
            lblFacultad = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            pbFotoPrincipal = new PictureBox();
            pnlGene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoPrincipal).BeginInit();
            SuspendLayout();
            // 
            // pnlGene
            // 
            pnlGene.Controls.Add(btnComentar);
            pnlGene.Controls.Add(txtComentario);
            pnlGene.Controls.Add(pictureBox1);
            pnlGene.Controls.Add(flpAlbumFotos);
            pnlGene.Controls.Add(lblFacultad);
            pnlGene.Controls.Add(lblDescripcion);
            pnlGene.Controls.Add(lblNombre);
            pnlGene.Controls.Add(pbFotoPrincipal);
            pnlGene.Dock = DockStyle.Fill;
            pnlGene.Location = new Point(0, 0);
            pnlGene.Name = "pnlGene";
            pnlGene.Size = new Size(964, 598);
            pnlGene.TabIndex = 0;
            pnlGene.Paint += pnlGene_Paint;
            // 
            // btnComentar
            // 
            btnComentar.Location = new Point(349, 390);
            btnComentar.Name = "btnComentar";
            btnComentar.Size = new Size(242, 60);
            btnComentar.TabIndex = 7;
            btnComentar.Text = "Comentar";
            btnComentar.UseVisualStyleBackColor = true;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(34, 390);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(278, 60);
            txtComentario.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(585, 273);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // flpAlbumFotos
            // 
            flpAlbumFotos.AutoScroll = true;
            flpAlbumFotos.Location = new Point(34, 253);
            flpAlbumFotos.Name = "flpAlbumFotos";
            flpAlbumFotos.Size = new Size(530, 110);
            flpAlbumFotos.TabIndex = 4;
            flpAlbumFotos.WrapContents = false;
            // 
            // lblFacultad
            // 
            lblFacultad.AutoSize = true;
            lblFacultad.Location = new Point(279, 155);
            lblFacultad.Name = "lblFacultad";
            lblFacultad.Size = new Size(21, 25);
            lblFacultad.TabIndex = 3;
            lblFacultad.Text = "F";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(279, 93);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(25, 25);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "D";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(279, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(25, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "N";
            // 
            // pbFotoPrincipal
            // 
            pbFotoPrincipal.Location = new Point(49, 36);
            pbFotoPrincipal.Name = "pbFotoPrincipal";
            pbFotoPrincipal.Size = new Size(180, 180);
            pbFotoPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoPrincipal.TabIndex = 0;
            pbFotoPrincipal.TabStop = false;
            // 
            // GaleriaEmprendimientoView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlGene);
            Name = "GaleriaEmprendimientoView";
            Size = new Size(964, 598);
            Load += GaleriaEmprendimientoView_Load;
            pnlGene.ResumeLayout(false);
            pnlGene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotoPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGene;
        private Label lblNombre;
        private PictureBox pbFotoPrincipal;
        private FlowLayoutPanel flpAlbumFotos;
        private Label lblFacultad;
        private Label lblDescripcion;
        private PictureBox pictureBox1;
        private Button btnComentar;
        private TextBox txtComentario;
    }
}