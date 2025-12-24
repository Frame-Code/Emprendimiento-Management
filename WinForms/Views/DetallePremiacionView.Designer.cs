using System.ComponentModel;

namespace WinForms.Views;

partial class DetallePremiacionView
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
        BtnReporte = new System.Windows.Forms.Button();
        GridEmprendimientos = new System.Windows.Forms.DataGridView();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        LblNombre = new System.Windows.Forms.Label();
        LblInicio = new System.Windows.Forms.Label();
        LblOservacion = new System.Windows.Forms.Label();
        LblFin = new System.Windows.Forms.Label();
        LblCreacion = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)GridEmprendimientos).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(20, 17);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(554, 30);
        label1.TabIndex = 0;
        label1.Text = "Detalle de premiación";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(20, 67);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(75, 22);
        label2.TabIndex = 1;
        label2.Text = "Nombre:";
        // 
        // BtnReporte
        // 
        BtnReporte.Location = new System.Drawing.Point(251, 495);
        BtnReporte.Name = "BtnReporte";
        BtnReporte.Size = new System.Drawing.Size(741, 40);
        BtnReporte.TabIndex = 3;
        BtnReporte.Text = "Generar reporte";
        BtnReporte.UseVisualStyleBackColor = true;
        // 
        // GridEmprendimientos
        // 
        GridEmprendimientos.ColumnHeadersHeight = 29;
        GridEmprendimientos.Location = new System.Drawing.Point(20, 232);
        GridEmprendimientos.Name = "GridEmprendimientos";
        GridEmprendimientos.RowHeadersWidth = 51;
        GridEmprendimientos.Size = new System.Drawing.Size(1188, 238);
        GridEmprendimientos.TabIndex = 4;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(20, 144);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(112, 22);
        label3.TabIndex = 5;
        label3.Text = "Observación:";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(20, 105);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(112, 22);
        label4.TabIndex = 6;
        label4.Text = "Fecha Inicio:";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(638, 105);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(112, 22);
        label5.TabIndex = 7;
        label5.Text = "Fecha fin:";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(638, 67);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(129, 22);
        label6.TabIndex = 8;
        label6.Text = "Fecha creación:";
        // 
        // LblNombre
        // 
        LblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        LblNombre.Location = new System.Drawing.Point(101, 67);
        LblNombre.Name = "LblNombre";
        LblNombre.Size = new System.Drawing.Size(531, 22);
        LblNombre.TabIndex = 9;
        // 
        // LblInicio
        // 
        LblInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        LblInicio.Location = new System.Drawing.Point(122, 105);
        LblInicio.Name = "LblInicio";
        LblInicio.Size = new System.Drawing.Size(492, 22);
        LblInicio.TabIndex = 10;
        // 
        // LblOservacion
        // 
        LblOservacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        LblOservacion.Location = new System.Drawing.Point(122, 144);
        LblOservacion.Name = "LblOservacion";
        LblOservacion.Size = new System.Drawing.Size(1086, 47);
        LblOservacion.TabIndex = 11;
        // 
        // LblFin
        // 
        LblFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        LblFin.Location = new System.Drawing.Point(726, 105);
        LblFin.Name = "LblFin";
        LblFin.Size = new System.Drawing.Size(492, 22);
        LblFin.TabIndex = 12;
        // 
        // LblCreacion
        // 
        LblCreacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        LblCreacion.Location = new System.Drawing.Point(756, 67);
        LblCreacion.Name = "LblCreacion";
        LblCreacion.Size = new System.Drawing.Size(492, 22);
        LblCreacion.TabIndex = 13;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(20, 207);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(531, 22);
        label7.TabIndex = 14;
        label7.Text = "Votaciones:";
        // 
        // DetallePremiacionView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1247, 681);
        Controls.Add(label7);
        Controls.Add(LblCreacion);
        Controls.Add(LblFin);
        Controls.Add(LblOservacion);
        Controls.Add(LblInicio);
        Controls.Add(LblNombre);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(GridEmprendimientos);
        Controls.Add(BtnReporte);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "DetallePremiacionView";
        ((System.ComponentModel.ISupportInitialize)GridEmprendimientos).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label LblInicio;
    private System.Windows.Forms.Label LblOservacion;
    private System.Windows.Forms.Label LblFin;
    private System.Windows.Forms.Label LblCreacion;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label LblNombre;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button BtnReporte;
    private System.Windows.Forms.DataGridView GridEmprendimientos;

    #endregion
}