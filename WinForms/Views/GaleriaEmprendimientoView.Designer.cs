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
            pbFoto = new PictureBox();
            btnGuardar = new Button();
            txtComentario = new TextBox();
            flpFotos = new FlowLayoutPanel();
            flpComentarios = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(177, 33);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(132, 94);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 0;
            pbFoto.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(417, 100);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Comentar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(395, 33);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(169, 37);
            txtComentario.TabIndex = 3;
            // 
            // flpFotos
            // 
            flpFotos.AutoScroll = true;
            flpFotos.Location = new Point(21, 168);
            flpFotos.Name = "flpFotos";
            flpFotos.Size = new Size(434, 330);
            flpFotos.TabIndex = 4;
            
            // 
            // flpComentarios
            // 
            flpComentarios.AutoScroll = true;
            flpComentarios.FlowDirection = FlowDirection.TopDown;
            flpComentarios.Location = new Point(35, 590);
            flpComentarios.Name = "flpComentarios";
            flpComentarios.Size = new Size(396, 121);
            flpComentarios.TabIndex = 5;
            flpComentarios.WrapContents = false;
            // 
            // GaleriaEmprendimientoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpComentarios);
            Controls.Add(flpFotos);
            Controls.Add(txtComentario);
            Controls.Add(btnGuardar);
            Controls.Add(pbFoto);
            Name = "GaleriaEmprendimientoView";
            Size = new Size(669, 754);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFoto;
        private Button btnGuardar;
        private TextBox txtComentario;
        private FlowLayoutPanel flpFotos;
        private FlowLayoutPanel flpComentarios;
    }
}