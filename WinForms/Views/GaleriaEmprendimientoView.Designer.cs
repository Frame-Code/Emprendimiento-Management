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
            flpFotos = new FlowLayoutPanel();
            txtComentario = new TextBox();
            btnComentar = new Button();
            pnlGaleria = new Panel();
            SuspendLayout();
            // 
            // flpFotos
            // 
            flpFotos.AutoScroll = true;
            flpFotos.Location = new Point(20, 46);
            flpFotos.Name = "flpFotos";
            flpFotos.Size = new Size(547, 135);
            flpFotos.TabIndex = 0;
            flpFotos.Visible = false;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(38, 321);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(467, 46);
            txtComentario.TabIndex = 2;
            // 
            // btnComentar
            // 
            btnComentar.Location = new Point(544, 333);
            btnComentar.Name = "btnComentar";
            btnComentar.Size = new Size(112, 34);
            btnComentar.TabIndex = 3;
            btnComentar.Text = "Comentar";
            btnComentar.UseVisualStyleBackColor = true;
            // 
            // pnlGaleria
            // 
            pnlGaleria.AutoScroll = true;
            pnlGaleria.Location = new Point(20, 388);
            pnlGaleria.Name = "pnlGaleria";
            pnlGaleria.Size = new Size(567, 142);
            pnlGaleria.TabIndex = 4;
            pnlGaleria.Visible = false;
            // 
            // GaleriaEmprendimientoView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlGaleria);
            Controls.Add(btnComentar);
            Controls.Add(txtComentario);
            Controls.Add(flpFotos);
            Name = "GaleriaEmprendimientoView";
            Size = new Size(1144, 583);
            Load += GaleriaEmprendimientoView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpFotos;
        private TextBox txtComentario;
        private Button btnComentar;
        private Panel pnlGaleria;
    }
}