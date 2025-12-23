using System.ComponentModel;

namespace WinForms.Views.UserControls;

partial class ResultadoEventoUc
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
        label1 = new System.Windows.Forms.Label();
        GridPremiaciones = new System.Windows.Forms.DataGridView();
        button1 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)GridPremiaciones).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(0, -9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(477, 31);
        label1.TabIndex = 0;
        label1.Text = " Premiaciones registradas";
        label1.Click += label1_Click;
        // 
        // GridPremiaciones
        // 
        GridPremiaciones.ColumnHeadersHeight = 29;
        GridPremiaciones.Location = new System.Drawing.Point(3, 45);
        GridPremiaciones.Name = "GridPremiaciones";
        GridPremiaciones.RowHeadersWidth = 51;
        GridPremiaciones.Size = new System.Drawing.Size(1250, 347);
        GridPremiaciones.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(194, 410);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(785, 39);
        button1.TabIndex = 2;
        button1.Text = "Registrar nueva premiacion";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // ResultadoEventoUc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(button1);
        Controls.Add(GridPremiaciones);
        Controls.Add(label1);
        Size = new System.Drawing.Size(1368, 873);
        Load += ResultadoEventoUc_Load;
        ((System.ComponentModel.ISupportInitialize)GridPremiaciones).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.DataGridView GridPremiaciones;

    private System.Windows.Forms.Label label1;

    #endregion
}