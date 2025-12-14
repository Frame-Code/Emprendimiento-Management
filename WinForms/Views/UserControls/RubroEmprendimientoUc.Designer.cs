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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        BtnRegistrar = new Button();
        GridRubros = new DataGridView();
        label1 = new Label();
        label2 = new Label();
        TxtNombre = new TextBox();
        label3 = new Label();
        label4 = new Label();
        TxtDescripcion = new TextBox();
        ((ISupportInitialize)GridRubros).BeginInit();
        SuspendLayout();
        // 
        // BtnRegistrar
        // 
        BtnRegistrar.Location = new Point(194, 667);
        BtnRegistrar.Name = "BtnRegistrar";
        BtnRegistrar.Size = new Size(572, 43);
        BtnRegistrar.TabIndex = 0;
        BtnRegistrar.Text = "Registrar";
        BtnRegistrar.UseVisualStyleBackColor = true;
        BtnRegistrar.Click += BtnRegistrar_Click;
        // 
        // GridRubros
        // 
        GridRubros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        GridRubros.ColumnHeadersHeight = 29;
        GridRubros.DefaultCellStyle = dataGridViewCellStyle2;
        GridRubros.Location = new Point(15, 52);
        GridRubros.Name = "GridRubros";
        GridRubros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        GridRubros.RowHeadersWidth = 51;
        GridRubros.Size = new Size(1495, 548);
        GridRubros.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(15, 14);
        label1.Name = "label1";
        label1.Size = new Size(673, 25);
        label1.TabIndex = 2;
        label1.Text = "Rubros de emprendimientos registrados";
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(15, 583);
        label2.Name = "label2";
        label2.Size = new Size(90, 27);
        label2.TabIndex = 3;
        label2.Text = "Nombre:";
        // 
        // TxtNombre
        // 
        TxtNombre.Location = new Point(122, 583);
        TxtNombre.Name = "TxtNombre";
        TxtNombre.Size = new Size(866, 27);
        TxtNombre.TabIndex = 4;
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(15, 549);
        label3.Name = "label3";
        label3.Size = new Size(673, 25);
        label3.TabIndex = 5;
        label3.Text = "Registrar nuevo rubro";
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label4.Location = new Point(15, 625);
        label4.Name = "label4";
        label4.Size = new Size(90, 27);
        label4.TabIndex = 6;
        label4.Text = "Descripcion:";
        // 
        // TxtDescripcion
        // 
        TxtDescripcion.Location = new Point(122, 625);
        TxtDescripcion.Name = "TxtDescripcion";
        TxtDescripcion.Size = new Size(866, 27);
        TxtDescripcion.TabIndex = 7;
        // 
        // RubroEmprendimientoUc
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(TxtDescripcion);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(TxtNombre);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(GridRubros);
        Controls.Add(BtnRegistrar);
        Name = "RubroEmprendimientoUc";
        Size = new Size(1754, 892);
        Load += RubroEmprendimientoUc_Load;
        ((ISupportInitialize)GridRubros).EndInit();
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