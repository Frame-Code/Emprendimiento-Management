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
        BtnEventos = new Button();
        BtnResultadoEventos = new Button();
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
        panel1.Name = "panel1";
        panel1.Size = new Size(1265, 752);
        panel1.TabIndex = 1;
        // 
        // PnlContenedor
        // 
        PnlContenedor.Dock = DockStyle.Fill;
        PnlContenedor.Location = new Point(239, 61);
        PnlContenedor.Name = "PnlContenedor";
        PnlContenedor.Size = new Size(1026, 691);
        PnlContenedor.TabIndex = 8;
        // 
        // panel3
        // 
        panel3.BackColor = Color.Silver;
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Controls.Add(BtnResultadoEventos);
        panel3.Controls.Add(BtnEventos);
        panel3.Controls.Add(BtnParticipantes);
        panel3.Controls.Add(BtnFacultades);
        panel3.Controls.Add(label3);
        panel3.Controls.Add(BtnEmprendimiento);
        panel3.Controls.Add(LblUserName);
        panel3.Dock = DockStyle.Left;
        panel3.Location = new Point(0, 61);
        panel3.Name = "panel3";
        panel3.Size = new Size(239, 691);
        panel3.TabIndex = 7;
        // 
        // BtnParticipantes
        // 
        BtnParticipantes.BackColor = Color.FromArgb(224, 224, 224);
        BtnParticipantes.Location = new Point(12, 224);
        BtnParticipantes.Name = "BtnParticipantes";
        BtnParticipantes.Size = new Size(199, 39);
        BtnParticipantes.TabIndex = 8;
        BtnParticipantes.Text = "Participantes";
        BtnParticipantes.UseVisualStyleBackColor = false;
        // 
        // BtnFacultades
        // 
        BtnFacultades.BackColor = Color.FromArgb(224, 224, 224);
        BtnFacultades.Location = new Point(12, 155);
        BtnFacultades.Name = "BtnFacultades";
        BtnFacultades.Size = new Size(199, 39);
        BtnFacultades.TabIndex = 7;
        BtnFacultades.Text = "Facultades";
        BtnFacultades.UseVisualStyleBackColor = false;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11F);
        label3.Location = new Point(3, 40);
        label3.Margin = new Padding(1, 0, 1, 0);
        label3.Name = "label3";
        label3.Size = new Size(236, 25);
        label3.TabIndex = 6;
        label3.Text = "____________________________";
        // 
        // BtnEmprendimiento
        // 
        BtnEmprendimiento.BackColor = Color.FromArgb(224, 224, 224);
        BtnEmprendimiento.Location = new Point(12, 86);
        BtnEmprendimiento.Name = "BtnEmprendimiento";
        BtnEmprendimiento.Size = new Size(199, 39);
        BtnEmprendimiento.TabIndex = 3;
        BtnEmprendimiento.Text = "Emprendimientos";
        BtnEmprendimiento.UseVisualStyleBackColor = false;
        BtnEmprendimiento.Click += BtnEmprendimiento_Click;
        // 
        // LblUserName
        // 
        LblUserName.AutoSize = true;
        LblUserName.Font = new Font("Segoe UI", 11F);
        LblUserName.Location = new Point(12, 15);
        LblUserName.Name = "LblUserName";
        LblUserName.Size = new Size(100, 25);
        LblUserName.TabIndex = 4;
        LblUserName.Text = "UserName";
        // 
        // panel2
        // 
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(1265, 61);
        panel2.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(370, 35);
        label1.TabIndex = 8;
        label1.Text = "Administrar emprendimientos";
        // 
        // BtnEventos
        // 
        BtnEventos.BackColor = Color.FromArgb(224, 224, 224);
        BtnEventos.Location = new Point(12, 297);
        BtnEventos.Name = "BtnEventos";
        BtnEventos.Size = new Size(199, 39);
        BtnEventos.TabIndex = 9;
        BtnEventos.Text = "Eventos";
        BtnEventos.UseVisualStyleBackColor = false;
        // 
        // BtnResultadoEventos
        // 
        BtnResultadoEventos.BackColor = Color.FromArgb(224, 224, 224);
        BtnResultadoEventos.Location = new Point(11, 371);
        BtnResultadoEventos.Name = "BtnResultadoEventos";
        BtnResultadoEventos.Size = new Size(199, 39);
        BtnResultadoEventos.TabIndex = 10;
        BtnResultadoEventos.Text = "Resultados Eventos";
        BtnResultadoEventos.UseVisualStyleBackColor = false;
        // 
        // MainFormView
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonFace;
        ClientSize = new Size(1265, 752);
        Controls.Add(panel1);
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
    private Button BtnEventos;
    private Button BtnResultadoEventos;
}