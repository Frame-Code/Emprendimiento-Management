using System.ComponentModel;

namespace WinForms.Views.UserControls;

partial class VotoEventoUc
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        BtnVotar = new System.Windows.Forms.Button();
        DgvEmprendimientos = new System.Windows.Forms.DataGridView();
        TxtComentario = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        LblEmprendimientoSelected = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)DgvEmprendimientos).BeginInit();
        SuspendLayout();
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(30, 951);
        label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(967, 62);
        label2.TabIndex = 2;
        label2.Visible = false;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label3.Location = new System.Drawing.Point(314, 0);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(567, 42);
        label3.TabIndex = 4;
        label3.Text = "Vota por tu emprendimiento favorito!";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(24, 67);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(496, 30);
        label1.TabIndex = 5;
        label1.Text = "Selecciona tu emprendimiento favorito:";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(24, 561);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(589, 24);
        label6.TabIndex = 8;
        label6.Text = "Opcional: escribe un comentario de tu emprendimiento:";
        // 
        // BtnVotar
        // 
        BtnVotar.Location = new System.Drawing.Point(218, 751);
        BtnVotar.Name = "BtnVotar";
        BtnVotar.Size = new System.Drawing.Size(915, 41);
        BtnVotar.TabIndex = 9;
        BtnVotar.Text = "Votar";
        BtnVotar.UseVisualStyleBackColor = true;
        BtnVotar.Click += BtnVotar_Click;
        // 
        // DgvEmprendimientos
        // 
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        DgvEmprendimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        DgvEmprendimientos.ColumnHeadersHeight = 29;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        DgvEmprendimientos.DefaultCellStyle = dataGridViewCellStyle2;
        DgvEmprendimientos.Location = new System.Drawing.Point(24, 100);
        DgvEmprendimientos.Name = "DgvEmprendimientos";
        dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        DgvEmprendimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        DgvEmprendimientos.RowHeadersWidth = 51;
        DgvEmprendimientos.Size = new System.Drawing.Size(1339, 396);
        DgvEmprendimientos.TabIndex = 10;
        DgvEmprendimientos.CellContentClick += DgvEmprendimientos_CellContentClick;
        // 
        // TxtComentario
        // 
        TxtComentario.AcceptsTab = true;
        TxtComentario.Location = new System.Drawing.Point(24, 599);
        TxtComentario.Multiline = true;
        TxtComentario.Name = "TxtComentario";
        TxtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        TxtComentario.Size = new System.Drawing.Size(1339, 146);
        TxtComentario.TabIndex = 11;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(25, 517);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(224, 29);
        label4.TabIndex = 12;
        label4.Text = "Emprendimiento seleccionado: ";
        // 
        // LblEmprendimientoSelected
        // 
        LblEmprendimientoSelected.Location = new System.Drawing.Point(241, 517);
        LblEmprendimientoSelected.Name = "LblEmprendimientoSelected";
        LblEmprendimientoSelected.Size = new System.Drawing.Size(611, 29);
        LblEmprendimientoSelected.TabIndex = 13;
        // 
        // VotoEventoUc
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        Controls.Add(LblEmprendimientoSelected);
        Controls.Add(label4);
        Controls.Add(TxtComentario);
        Controls.Add(DgvEmprendimientos);
        Controls.Add(BtnVotar);
        Controls.Add(label6);
        Controls.Add(label1);
        Controls.Add(label3);
        Controls.Add(label2);
        Location = new System.Drawing.Point(19, 19);
        Margin = new System.Windows.Forms.Padding(6);
        Size = new System.Drawing.Size(1381, 915);
        Load += VotoEventoUc_Load;
        ((System.ComponentModel.ISupportInitialize)DgvEmprendimientos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label LblEmprendimientoSelected;

    private System.Windows.Forms.DataGridView DgvEmprendimientos;
    private System.Windows.Forms.TextBox TxtComentario;

    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button BtnVotar;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}