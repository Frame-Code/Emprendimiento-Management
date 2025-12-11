namespace WinForms;

partial class MainFormView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        PnlContenedor = new Panel();
        panel3 = new Panel();
        BtnParticipantes = new Button();
        BtnFacultades = new Button();
        label3 = new Label();
        BtnEmprendimiento = new Button();
        LblUserName = new Label();
        panel2 = new Panel();
        label1 = new Label();
        BtnCalendario = new Button();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ButtonHighlight;
        panel1.Controls.Add(PnlContenedor);
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(3, 2, 3, 2);
        panel1.Name = "panel1";
        panel1.Size = new Size(1107, 564);
        panel1.TabIndex = 1;
        // 
        // PnlContenedor
        // 
        PnlContenedor.Dock = DockStyle.Fill;
        PnlContenedor.Location = new Point(209, 46);
        PnlContenedor.Margin = new Padding(3, 2, 3, 2);
        PnlContenedor.Name = "PnlContenedor";
        PnlContenedor.Size = new Size(898, 518);
        PnlContenedor.TabIndex = 8;
        // 
        // panel3
        // 
        panel3.BackColor = Color.Silver;
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Controls.Add(BtnCalendario);
        panel3.Controls.Add(BtnParticipantes);
        panel3.Controls.Add(BtnFacultades);
        panel3.Controls.Add(label3);
        panel3.Controls.Add(BtnEmprendimiento);
        panel3.Controls.Add(LblUserName);
        panel3.Dock = DockStyle.Left;
        panel3.Location = new Point(0, 46);
        panel3.Margin = new Padding(3, 2, 3, 2);
        panel3.Name = "panel3";
        panel3.Size = new Size(209, 518);
        panel3.TabIndex = 7;
        // 
        // BtnParticipantes
        // 
        BtnParticipantes.BackColor = Color.FromArgb(224, 224, 224);
        BtnParticipantes.Location = new Point(10, 168);
        BtnParticipantes.Margin = new Padding(3, 2, 3, 2);
        BtnParticipantes.Name = "BtnParticipantes";
        BtnParticipantes.Size = new Size(174, 29);
        BtnParticipantes.TabIndex = 8;
        BtnParticipantes.Text = "Particpantes";
        BtnParticipantes.UseVisualStyleBackColor = false;
        // 
        // BtnFacultades
        // 
        BtnFacultades.BackColor = Color.FromArgb(224, 224, 224);
        BtnFacultades.Location = new Point(10, 116);
        BtnFacultades.Margin = new Padding(3, 2, 3, 2);
        BtnFacultades.Name = "BtnFacultades";
        BtnFacultades.Size = new Size(174, 29);
        BtnFacultades.TabIndex = 7;
        BtnFacultades.Text = "Facultades";
        BtnFacultades.UseVisualStyleBackColor = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11F);
        label3.Location = new Point(3, 30);
        label3.Name = "label3";
        label3.Size = new Size(177, 20);
        label3.TabIndex = 6;
        label3.Text = "____________________________";
        // 
        // BtnEmprendimiento
        // 
        BtnEmprendimiento.BackColor = Color.FromArgb(224, 224, 224);
        BtnEmprendimiento.Location = new Point(10, 64);
        BtnEmprendimiento.Margin = new Padding(3, 2, 3, 2);
        BtnEmprendimiento.Name = "BtnEmprendimiento";
        BtnEmprendimiento.Size = new Size(174, 29);
        BtnEmprendimiento.TabIndex = 3;
        BtnEmprendimiento.Text = "Emprendimientos";
        BtnEmprendimiento.UseVisualStyleBackColor = false;
        BtnEmprendimiento.Click += BtnEmprendimiento_Click;
        // 
        // LblUserName
        // 
        LblUserName.AutoSize = true;
        LblUserName.Font = new Font("Segoe UI", 11F);
        LblUserName.Location = new Point(10, 11);
        LblUserName.Name = "LblUserName";
        LblUserName.Size = new Size(78, 20);
        LblUserName.TabIndex = 4;
        LblUserName.Text = "UserName";
        // 
        // panel2
        // 
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(3, 2, 3, 2);
        panel2.Name = "panel2";
        panel2.Size = new Size(1107, 46);
        panel2.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label1.Location = new Point(10, 7);
        label1.Name = "label1";
        label1.Size = new Size(296, 28);
        label1.TabIndex = 8;
        label1.Text = "Administrar emprendimientos";
        // 
        // BtnCalendario
        // 
        BtnCalendario.BackColor = Color.FromArgb(224, 224, 224);
        BtnCalendario.Location = new Point(10, 216);
        BtnCalendario.Margin = new Padding(3, 2, 3, 2);
        BtnCalendario.Name = "BtnCalendario";
        BtnCalendario.Size = new Size(174, 29);
        BtnCalendario.TabIndex = 10;
        BtnCalendario.Text = "Calendario";
        BtnCalendario.UseVisualStyleBackColor = false;
        BtnCalendario.Click += BtnCalendario_Click;
        // 
        // MainFormView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonFace;
        ClientSize = new Size(1107, 564);
        Controls.Add(panel1);
        Margin = new Padding(3, 2, 3, 2);
        Name = "MainFormView";
        Text = "Form1";
        WindowState = FormWindowState.Maximized;
        panel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Panel panel1;
    private Panel PnlContenedor;
    private Panel panel3;
    private Button BtnEmprendimiento;
    private Label LblUserName;
    private Panel panel2;
    private Label label1;
    private Button BtnParticipantes;
    private Button BtnFacultades;
    private Label label3;
    private Button BtnCalendario;
}