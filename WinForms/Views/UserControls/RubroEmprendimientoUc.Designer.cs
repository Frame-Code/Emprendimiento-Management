using System.ComponentModel;

namespace WinForms.Views.UserControls;

partial class RubroEmprendimientoUc
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        BtnRegistrar = new System.Windows.Forms.Button();
        GridRubros = new System.Windows.Forms.DataGridView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        TxtNombre = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        TxtDescripcion = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)GridRubros).BeginInit();
        SuspendLayout();
        // 
        // BtnRegistrar
        // 
        BtnRegistrar.Location = new System.Drawing.Point(215, 776);
        BtnRegistrar.Name = "BtnRegistrar";
        BtnRegistrar.Size = new System.Drawing.Size(572, 43);
        BtnRegistrar.TabIndex = 0;
        BtnRegistrar.Text = "Registrar";
        BtnRegistrar.UseVisualStyleBackColor = true;
        BtnRegistrar.Click += BtnRegistrar_Click;
        // 
        // GridRubros
        // 
        GridRubros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        GridRubros.ColumnHeadersHeight = 29;
        GridRubros.Location = new System.Drawing.Point(15, 52);
        GridRubros.Name = "GridRubros";
        GridRubros.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
        GridRubros.RowHeadersWidth = 51;
        GridRubros.Size = new System.Drawing.Size(1495, 548);
        GridRubros.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(15, 14);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(673, 25);
        label1.TabIndex = 2;
        label1.Text = "Rubros de emprendimientos registrados";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(17, 667);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(90, 27);
        label2.TabIndex = 3;
        label2.Text = "Nombre:";
        // 
        // TxtNombre
        // 
        TxtNombre.Location = new System.Drawing.Point(124, 667);
        TxtNombre.Name = "TxtNombre";
        TxtNombre.Size = new System.Drawing.Size(866, 27);
        TxtNombre.TabIndex = 4;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(15, 621);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(673, 25);
        label3.TabIndex = 5;
        label3.Text = "Registrar nuevo rubro";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(16, 722);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(90, 27);
        label4.TabIndex = 6;
        label4.Text = "Descripcion:";
        // 
        // TxtDescripcion
        // 
        TxtDescripcion.Location = new System.Drawing.Point(123, 722);
        TxtDescripcion.Name = "TxtDescripcion";
        TxtDescripcion.Size = new System.Drawing.Size(866, 27);
        TxtDescripcion.TabIndex = 7;
        // 
        // RubroEmprendimientoUc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(TxtDescripcion);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(TxtNombre);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(GridRubros);
        Controls.Add(BtnRegistrar);
        Size = new System.Drawing.Size(1754, 892);
        Load += RubroEmprendimientoUc_Load;
        ((System.ComponentModel.ISupportInitialize)GridRubros).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox TxtDescripcion;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.DataGridView GridRubros;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TxtNombre;

    private System.Windows.Forms.Button BtnRegistrar;

    #endregion
}