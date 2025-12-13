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
        roundedPanel1 = new WinForms.Views.Util.RoundedPanel();
        BtnResultadoEventos = new Button();
        BtnFacultades = new Button();
        BtnEventos = new Button();
        BtnEmprendimiento = new Button();
        BtnParticipantes = new Button();
        roundedPanel2 = new WinForms.Views.Util.RoundedPanel();
        LblUserName = new Label();
        panel2 = new Panel();
        label1 = new Label();
        BtnCalendario = new Button();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        roundedPanel1.SuspendLayout();
        roundedPanel2.SuspendLayout();
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
        PnlContenedor.Location = new Point(256, 55);
        PnlContenedor.Name = "PnlContenedor";
        PnlContenedor.Size = new Size(1009, 697);
        PnlContenedor.TabIndex = 8;
        // 
        // panel3
        // 
        panel3.BackColor = SystemColors.ButtonHighlight;
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Controls.Add(roundedPanel1);
        panel3.Controls.Add(roundedPanel2);
        panel3.Dock = DockStyle.Left;
        panel3.Location = new Point(0, 55);
        panel3.Name = "panel3";
        panel3.Size = new Size(256, 697);
        panel3.TabIndex = 7;
        // 
        // roundedPanel1
        // 
        roundedPanel1.BackColor = Color.FromArgb(250, 250, 250);
        roundedPanel1.BorderColor = Color.LightGray;
        roundedPanel1.BorderRadius = 20;
        roundedPanel1.BorderSize = 1;
        roundedPanel1.Controls.Add(BtnResultadoEventos);
        roundedPanel1.Controls.Add(BtnFacultades);
        roundedPanel1.Controls.Add(BtnEventos);
        roundedPanel1.Controls.Add(BtnEmprendimiento);
        roundedPanel1.Controls.Add(BtnParticipantes);
        roundedPanel1.Location = new Point(11, 5);
        roundedPanel1.Name = "roundedPanel1";
        roundedPanel1.Size = new Size(235, 606);
        roundedPanel1.TabIndex = 0;
        // 
        // BtnResultadoEventos
        // 
        BtnResultadoEventos.BackColor = Color.FromArgb(224, 224, 224);
        BtnResultadoEventos.Location = new Point(17, 310);
        BtnResultadoEventos.Name = "BtnResultadoEventos";
        BtnResultadoEventos.Size = new Size(199, 39);
        BtnResultadoEventos.TabIndex = 10;
        BtnResultadoEventos.Text = "Resultados Eventos";
        BtnResultadoEventos.UseVisualStyleBackColor = false;
        // 
        // BtnFacultades
        // 
        BtnFacultades.BackColor = Color.FromArgb(224, 224, 224);
        BtnFacultades.Location = new Point(18, 94);
        BtnFacultades.Name = "BtnFacultades";
        BtnFacultades.Size = new Size(174, 29);
        BtnFacultades.TabIndex = 7;
        BtnFacultades.Text = "Facultades";
        BtnFacultades.UseVisualStyleBackColor = false;
        // 
        // BtnEventos
        // 
        BtnEventos.BackColor = Color.FromArgb(224, 224, 224);
        BtnEventos.Location = new Point(18, 236);
        BtnEventos.Name = "BtnEventos";
        BtnEventos.Size = new Size(199, 39);
        BtnEventos.TabIndex = 9;
        BtnEventos.Text = "Eventos";
        BtnEventos.UseVisualStyleBackColor = false;
        // 
        // BtnEmprendimiento
        // 
        BtnEmprendimiento.BackColor = Color.FromArgb(224, 224, 224);
        BtnEmprendimiento.Location = new Point(18, 25);
        BtnEmprendimiento.Name = "BtnEmprendimiento";
        BtnEmprendimiento.Size = new Size(174, 29);
        BtnEmprendimiento.TabIndex = 3;
        BtnEmprendimiento.Text = "Emprendimientos";
        BtnEmprendimiento.UseVisualStyleBackColor = false;
        BtnEmprendimiento.Click += BtnEmprendimiento_Click;
        // 
        // BtnParticipantes
        // 
        BtnParticipantes.BackColor = Color.FromArgb(224, 224, 224);
        BtnParticipantes.Location = new Point(18, 163);
        BtnParticipantes.Name = "BtnParticipantes";
        BtnParticipantes.Size = new Size(199, 39);
        BtnParticipantes.TabIndex = 8;
        BtnParticipantes.Text = "Participantes";
        BtnParticipantes.UseVisualStyleBackColor = false;
        // 
        // roundedPanel2
        // 
        roundedPanel2.BackColor = Color.FromArgb(250, 250, 250);
        roundedPanel2.BorderColor = Color.LightGray;
        roundedPanel2.BorderRadius = 20;
        roundedPanel2.BorderSize = 1;
        roundedPanel2.Controls.Add(LblUserName);
        roundedPanel2.Dock = DockStyle.Bottom;
        roundedPanel2.Location = new Point(0, 651);
        roundedPanel2.Name = "roundedPanel2";
        roundedPanel2.Size = new Size(254, 44);
        roundedPanel2.TabIndex = 5;
        // 
        // LblUserName
        // 
        LblUserName.AutoSize = true;
        LblUserName.Font = new Font("Segoe UI", 11F);
        LblUserName.Location = new Point(17, 10);
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
        panel2.Size = new Size(1265, 55);
        panel2.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label1.Location = new Point(473, 8);
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
        roundedPanel1.ResumeLayout(false);
        roundedPanel2.ResumeLayout(false);
        roundedPanel2.PerformLayout();
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
    private Button BtnEventos;
    private Button BtnResultadoEventos;
    private Button BtnCalendario;
    private Views.Util.RoundedPanel roundedPanel2;
    private Views.Util.RoundedPanel roundedPanel1;
}