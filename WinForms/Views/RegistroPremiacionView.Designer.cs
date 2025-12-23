using System.ComponentModel;

namespace WinForms.Views;

partial class RegistroPremiacionView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        TxtNombre = new System.Windows.Forms.TextBox();
        TxtObservacion = new System.Windows.Forms.TextBox();
        DtFechaInicio = new System.Windows.Forms.DateTimePicker();
        DtFechaFin = new System.Windows.Forms.DateTimePicker();
        GridPremiaciones = new System.Windows.Forms.DataGridView();
        label6 = new System.Windows.Forms.Label();
        LblEmprendimientos = new System.Windows.Forms.Label();
        BtnRegistrar = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)GridPremiaciones).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(40, 27);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(508, 32);
        label1.TabIndex = 0;
        label1.Text = "Registrar nuevas premiaciones";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(655, 180);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(78, 25);
        label2.TabIndex = 1;
        label2.Text = "Fecha fin:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(40, 132);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(104, 25);
        label3.TabIndex = 2;
        label3.Text = "Observacion:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(40, 89);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(70, 25);
        label4.TabIndex = 3;
        label4.Text = "Nombre:";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(40, 180);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(114, 25);
        label5.TabIndex = 4;
        label5.Text = "Fecha inicio:";
        // 
        // TxtNombre
        // 
        TxtNombre.Location = new System.Drawing.Point(150, 89);
        TxtNombre.Name = "TxtNombre";
        TxtNombre.Size = new System.Drawing.Size(1061, 27);
        TxtNombre.TabIndex = 5;
        // 
        // TxtObservacion
        // 
        TxtObservacion.Location = new System.Drawing.Point(150, 132);
        TxtObservacion.Name = "TxtObservacion";
        TxtObservacion.Size = new System.Drawing.Size(1061, 27);
        TxtObservacion.TabIndex = 6;
        // 
        // DtFechaInicio
        // 
        DtFechaInicio.Location = new System.Drawing.Point(150, 175);
        DtFechaInicio.Name = "DtFechaInicio";
        DtFechaInicio.Size = new System.Drawing.Size(472, 27);
        DtFechaInicio.TabIndex = 7;
        // 
        // DtFechaFin
        // 
        DtFechaFin.Location = new System.Drawing.Point(739, 178);
        DtFechaFin.Name = "DtFechaFin";
        DtFechaFin.Size = new System.Drawing.Size(472, 27);
        DtFechaFin.TabIndex = 8;
        // 
        // GridPremiaciones
        // 
        GridPremiaciones.ColumnHeadersHeight = 29;
        GridPremiaciones.Location = new System.Drawing.Point(47, 241);
        GridPremiaciones.Name = "GridPremiaciones";
        GridPremiaciones.RowHeadersWidth = 51;
        GridPremiaciones.Size = new System.Drawing.Size(1164, 189);
        GridPremiaciones.TabIndex = 9;
        GridPremiaciones.CellContentClick += GridPremiaciones_CellContentClick;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(56, 455);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(387, 24);
        label6.TabIndex = 10;
        label6.Text = "Emprendimientos registrados:";
        // 
        // LblEmprendimientos
        // 
        LblEmprendimientos.Location = new System.Drawing.Point(56, 488);
        LblEmprendimientos.Name = "LblEmprendimientos";
        LblEmprendimientos.Size = new System.Drawing.Size(917, 223);
        LblEmprendimientos.TabIndex = 11;
        // 
        // BtnRegistrar
        // 
        BtnRegistrar.Location = new System.Drawing.Point(150, 733);
        BtnRegistrar.Name = "BtnRegistrar";
        BtnRegistrar.Size = new System.Drawing.Size(849, 48);
        BtnRegistrar.TabIndex = 12;
        BtnRegistrar.Text = "Registrar premiacion";
        BtnRegistrar.UseVisualStyleBackColor = true;
        BtnRegistrar.Click += BtnRegistrar_Click;
        // 
        // RegistroPremiacionView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1291, 796);
        Controls.Add(BtnRegistrar);
        Controls.Add(LblEmprendimientos);
        Controls.Add(label6);
        Controls.Add(GridPremiaciones);
        Controls.Add(DtFechaFin);
        Controls.Add(DtFechaInicio);
        Controls.Add(TxtObservacion);
        Controls.Add(TxtNombre);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "RegistroPremiacion";
        Load += RegistroPremiacion_Load;
        ((System.ComponentModel.ISupportInitialize)GridPremiaciones).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button BtnRegistrar;

    private System.Windows.Forms.DataGridView GridPremiaciones;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label LblEmprendimientos;

    private System.Windows.Forms.TextBox TxtNombre;
    private System.Windows.Forms.TextBox TxtObservacion;
    private System.Windows.Forms.DateTimePicker DtFechaInicio;
    private System.Windows.Forms.DateTimePicker DtFechaFin;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    #endregion
}