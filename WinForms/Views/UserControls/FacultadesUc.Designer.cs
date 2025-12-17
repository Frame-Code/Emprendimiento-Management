using System.ComponentModel;

namespace WinForms.Views.UserControls;

partial class FacultadesUc
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
        BtnRegistrar = new System.Windows.Forms.Button();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        TxtNombre = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        TxtDescripcion = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // BtnRegistrar
        // 
        BtnRegistrar.Location = new System.Drawing.Point(427, 772);
        BtnRegistrar.Margin = new System.Windows.Forms.Padding(6);
        BtnRegistrar.Name = "BtnRegistrar";
        BtnRegistrar.Size = new System.Drawing.Size(654, 47);
        BtnRegistrar.TabIndex = 0;
        BtnRegistrar.Text = "Registrar";
        BtnRegistrar.UseVisualStyleBackColor = true;
        BtnRegistrar.Click += BtnRegistrar_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(38, 50);
        dataGridView1.Margin = new System.Windows.Forms.Padding(6);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(1495, 548);
        dataGridView1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(32, 9);
        label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(1430, 26);
        label1.TabIndex = 2;
        label1.Text = "Facultades registradas";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label2.Location = new System.Drawing.Point(38, 675);
        label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(88, 25);
        label2.TabIndex = 3;
        label2.Text = "Nombre:";
        // 
        // TxtNombre
        // 
        TxtNombre.Location = new System.Drawing.Point(146, 672);
        TxtNombre.Margin = new System.Windows.Forms.Padding(6);
        TxtNombre.Name = "TxtNombre";
        TxtNombre.Size = new System.Drawing.Size(1395, 27);
        TxtNombre.TabIndex = 4;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(38, 625);
        label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(1430, 29);
        label3.TabIndex = 5;
        label3.Text = "Registrar nueva facultad";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        label4.Location = new System.Drawing.Point(38, 719);
        label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(102, 31);
        label4.TabIndex = 6;
        label4.Text = "Descripcion:";
        // 
        // TxtDescripcion
        // 
        TxtDescripcion.Location = new System.Drawing.Point(146, 716);
        TxtDescripcion.Margin = new System.Windows.Forms.Padding(6);
        TxtDescripcion.Name = "TxtDescripcion";
        TxtDescripcion.Size = new System.Drawing.Size(1395, 27);
        TxtDescripcion.TabIndex = 7;
        // 
        // FacultadesUc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(TxtDescripcion);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(TxtNombre);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(dataGridView1);
        Controls.Add(BtnRegistrar);
        Margin = new System.Windows.Forms.Padding(6);
        Size = new System.Drawing.Size(2063, 1529);
        Load += FacultadesUc_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox TxtDescripcion;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TxtNombre;

    private System.Windows.Forms.Button BtnRegistrar;

    #endregion
}