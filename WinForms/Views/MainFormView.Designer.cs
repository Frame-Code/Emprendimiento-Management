namespace WinForms.Views;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        panel1 = new Panel();
        PnlContenedor = new Panel();
        panel3 = new Panel();
        roundedPanel1 = new WinForms.Views.Util.RoundedPanel();
        btnGaleria = new Button();
        BtnResultadoEventos = new Button();
        BtnGenerales = new Button();
        BtnEventos = new Button();
        BtnEmprendimiento = new Button();
        BtnParticipantes = new Button();
        roundedPanel2 = new WinForms.Views.Util.RoundedPanel();
        LblUserName = new Label();
        panel2 = new Panel();
        label1 = new Label();
        MenuOptions = new ContextMenuStrip(components);
        toolStripMenuItem1 = new ToolStripMenuItem();
        toolStripMenuItem2 = new ToolStripMenuItem();
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
        panel1.Margin = new Padding(5, 4, 5, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(1976, 1175);
        panel1.TabIndex = 1;
        // 
        // PnlContenedor
        // 
        PnlContenedor.Dock = DockStyle.Fill;
        PnlContenedor.Location = new Point(424, 68);
        PnlContenedor.Margin = new Padding(5, 6, 5, 6);
        PnlContenedor.Name = "PnlContenedor";
        PnlContenedor.Size = new Size(1552, 1107);
        PnlContenedor.TabIndex = 8;
        // 
        // panel3
        // 
        panel3.BackColor = SystemColors.ButtonHighlight;
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Controls.Add(roundedPanel1);
        panel3.Controls.Add(roundedPanel2);
        panel3.Dock = DockStyle.Left;
        panel3.Location = new Point(0, 68);
        panel3.Margin = new Padding(5, 6, 5, 6);
        panel3.Name = "panel3";
        panel3.Size = new Size(424, 1107);
        panel3.TabIndex = 7;
        // 
        // roundedPanel1
        // 
        roundedPanel1.BackColor = Color.FromArgb(250, 250, 250);
        roundedPanel1.BorderColor = Color.LightGray;
        roundedPanel1.BorderRadius = 20;
        roundedPanel1.BorderSize = 1;
        roundedPanel1.Controls.Add(btnGaleria);
        roundedPanel1.Controls.Add(BtnResultadoEventos);
        roundedPanel1.Controls.Add(BtnGenerales);
        roundedPanel1.Controls.Add(BtnEventos);
        roundedPanel1.Controls.Add(BtnEmprendimiento);
        roundedPanel1.Controls.Add(BtnParticipantes);
        roundedPanel1.Location = new Point(20, 10);
        roundedPanel1.Margin = new Padding(5, 6, 5, 6);
        roundedPanel1.Name = "roundedPanel1";
        roundedPanel1.Size = new Size(384, 971);
        roundedPanel1.TabIndex = 0;
        // 
        // btnGaleria
        // 
        btnGaleria.BackColor = Color.FromArgb(224, 224, 224);
        btnGaleria.Location = new Point(30, 611);
        btnGaleria.Margin = new Padding(5, 6, 5, 6);
        btnGaleria.Name = "btnGaleria";
        btnGaleria.Size = new Size(316, 60);
        btnGaleria.TabIndex = 11;
        btnGaleria.Text = "Galería";
        btnGaleria.UseVisualStyleBackColor = false;
        btnGaleria.Click += btnGaleria_Click;
        // 
        // BtnResultadoEventos
        // 
        BtnResultadoEventos.BackColor = Color.FromArgb(224, 224, 224);
        BtnResultadoEventos.Location = new Point(30, 496);
        BtnResultadoEventos.Margin = new Padding(5, 6, 5, 6);
        BtnResultadoEventos.Name = "BtnResultadoEventos";
        BtnResultadoEventos.Size = new Size(316, 60);
        BtnResultadoEventos.TabIndex = 10;
        BtnResultadoEventos.Text = "Resultado Eventos";
        BtnResultadoEventos.UseVisualStyleBackColor = false;
        // 
        // BtnGenerales
        // 
        BtnGenerales.BackColor = Color.FromArgb(224, 224, 224);
        BtnGenerales.Location = new Point(30, 41);
        BtnGenerales.Margin = new Padding(5, 6, 5, 6);
        BtnGenerales.Name = "BtnGenerales";
        BtnGenerales.Size = new Size(314, 60);
        BtnGenerales.TabIndex = 7;
        BtnGenerales.Text = "Maestros generales";
        BtnGenerales.UseVisualStyleBackColor = false;
        BtnGenerales.Click += BtnGenerales_Click;
        // 
        // BtnEventos
        // 
        BtnEventos.BackColor = Color.FromArgb(224, 224, 224);
        BtnEventos.Location = new Point(30, 382);
        BtnEventos.Margin = new Padding(5, 6, 5, 6);
        BtnEventos.Name = "BtnEventos";
        BtnEventos.Size = new Size(314, 60);
        BtnEventos.TabIndex = 9;
        BtnEventos.Text = "Eventos";
        BtnEventos.UseVisualStyleBackColor = false;
        BtnEventos.Click += BtnEventos_Click;
        // 
        // BtnEmprendimiento
        // 
        BtnEmprendimiento.BackColor = Color.FromArgb(224, 224, 224);
        BtnEmprendimiento.Location = new Point(30, 160);
        BtnEmprendimiento.Margin = new Padding(5, 6, 5, 6);
        BtnEmprendimiento.Name = "BtnEmprendimiento";
        BtnEmprendimiento.Size = new Size(311, 60);
        BtnEmprendimiento.TabIndex = 3;
        BtnEmprendimiento.Text = "Emprendimientos";
        BtnEmprendimiento.UseVisualStyleBackColor = false;
        BtnEmprendimiento.Click += BtnEmprendimiento_Click;
        // 
        // BtnParticipantes
        // 
        BtnParticipantes.BackColor = Color.FromArgb(224, 224, 224);
        BtnParticipantes.Location = new Point(30, 278);
        BtnParticipantes.Margin = new Padding(5, 6, 5, 6);
        BtnParticipantes.Name = "BtnParticipantes";
        BtnParticipantes.Size = new Size(314, 60);
        BtnParticipantes.TabIndex = 8;
        BtnParticipantes.Text = "Participantes";
        BtnParticipantes.UseVisualStyleBackColor = false;
        BtnParticipantes.Click += BtnParticipantes_Click;
        // 
        // roundedPanel2
        // 
        roundedPanel2.BackColor = Color.FromArgb(250, 250, 250);
        roundedPanel2.BorderColor = Color.LightGray;
        roundedPanel2.BorderRadius = 20;
        roundedPanel2.BorderSize = 1;
        roundedPanel2.Controls.Add(LblUserName);
        roundedPanel2.Dock = DockStyle.Bottom;
        roundedPanel2.Location = new Point(0, 1014);
        roundedPanel2.Margin = new Padding(4);
        roundedPanel2.Name = "roundedPanel2";
        roundedPanel2.Size = new Size(422, 91);
        roundedPanel2.TabIndex = 5;
        // 
        // LblUserName
        // 
        LblUserName.AutoSize = true;
        LblUserName.Font = new Font("Segoe UI", 11F);
        LblUserName.Location = new Point(30, 21);
        LblUserName.Margin = new Padding(5, 0, 5, 0);
        LblUserName.Name = "LblUserName";
        LblUserName.Size = new Size(129, 30);
        LblUserName.TabIndex = 4;
        LblUserName.Text = "Default user";
        // 
        // panel2
        // 
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(label1);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(5, 4, 5, 4);
        panel2.Name = "panel2";
        panel2.Size = new Size(1976, 68);
        panel2.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        label1.Location = new Point(845, 16);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(443, 41);
        label1.TabIndex = 8;
        label1.Text = "Administrar emprendimientos";
        // 
        // MenuOptions
        // 
        MenuOptions.ImageScalingSize = new Size(20, 20);
        MenuOptions.Name = "MenuOptions";
        MenuOptions.Size = new Size(61, 4);
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(32, 19);
        // 
        // toolStripMenuItem2
        // 
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new Size(32, 19);
        // 
        // MainFormView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonFace;
        ClientSize = new Size(1976, 1175);
        Controls.Add(panel1);
        Margin = new Padding(5, 4, 5, 4);
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

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ContextMenuStrip MenuOptions;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel PnlContenedor;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button BtnEmprendimiento;
    private Label LblUserName;
    private System.Windows.Forms.Panel panel2;
    private Label label1;
    private System.Windows.Forms.Button BtnParticipantes;
    private System.Windows.Forms.Button BtnGenerales;
    private System.Windows.Forms.Button BtnEventos;
    private System.Windows.Forms.Button BtnResultadoEventos;
    private WinForms.Views.Util.RoundedPanel roundedPanel2;
    private WinForms.Views.Util.RoundedPanel roundedPanel1;
    private Button btnGaleria;
}