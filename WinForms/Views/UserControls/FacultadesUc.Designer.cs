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
        BtnRegistrar.Location = new System.Drawing.Point(201, 578);
        BtnRegistrar.Name = "BtnRegistrar";
        BtnRegistrar.Size = new System.Drawing.Size(572, 43);
        BtnRegistrar.TabIndex = 0;
        BtnRegistrar.Text = "Registrar";
        BtnRegistrar.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeight = 29;
        dataGridView1.Location = new System.Drawing.Point(15, 52);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new System.Drawing.Size(953, 367);
        dataGridView1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(15, 14);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(673, 25);
        label1.TabIndex = 2;
        label1.Text = "Facultades registradas";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(15, 480);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(144, 27);
        label2.TabIndex = 3;
        label2.Text = "Nombre:";
        // 
        // TxtNombre
        // 
        TxtNombre.Location = new System.Drawing.Point(122, 480);
        TxtNombre.Name = "TxtNombre";
        TxtNombre.Size = new System.Drawing.Size(846, 27);
        TxtNombre.TabIndex = 4;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(15, 446);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(673, 25);
        label3.TabIndex = 5;
        label3.Text = "Registrar nueva facultad";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(15, 522);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(144, 27);
        label4.TabIndex = 6;
        label4.Text = "Descripcion:";
        // 
        // TxtDescripcion
        // 
        TxtDescripcion.Location = new System.Drawing.Point(122, 522);
        TxtDescripcion.Name = "TxtDescripcion";
        TxtDescripcion.Size = new System.Drawing.Size(846, 27);
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
        Size = new System.Drawing.Size(971, 746);
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