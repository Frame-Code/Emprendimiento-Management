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
        panel1 = new System.Windows.Forms.Panel();
        PnlContenedor = new System.Windows.Forms.Panel();
        panel3 = new System.Windows.Forms.Panel();
        roundedPanel1 = new WinForms.Views.Util.RoundedPanel();
        BtnResultadoEventos = new System.Windows.Forms.Button();
        BtnFacultades = new System.Windows.Forms.Button();
        BtnEventos = new System.Windows.Forms.Button();
        BtnEmprendimiento = new System.Windows.Forms.Button();
        BtnParticipantes = new System.Windows.Forms.Button();
        roundedPanel2 = new WinForms.Views.Util.RoundedPanel();
        LblUserName = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        roundedPanel1.SuspendLayout();
        roundedPanel2.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        panel1.Controls.Add(PnlContenedor);
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(panel2);
        panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(1581, 940);
        panel1.TabIndex = 1;
        // 
        // PnlContenedor
        // 
        PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
        PnlContenedor.Location = new System.Drawing.Point(340, 55);
        PnlContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        PnlContenedor.Name = "PnlContenedor";
        PnlContenedor.Size = new System.Drawing.Size(1241, 885);
        PnlContenedor.TabIndex = 8;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel3.Controls.Add(roundedPanel1);
        panel3.Controls.Add(roundedPanel2);
        panel3.Dock = System.Windows.Forms.DockStyle.Left;
        panel3.Location = new System.Drawing.Point(0, 55);
        panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(340, 885);
        panel3.TabIndex = 7;
        // 
        // roundedPanel1
        // 
        roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        roundedPanel1.BorderColor = System.Drawing.Color.LightGray;
        roundedPanel1.BorderRadius = 20;
        roundedPanel1.BorderSize = 1;
        roundedPanel1.Controls.Add(BtnResultadoEventos);
        roundedPanel1.Controls.Add(BtnFacultades);
        roundedPanel1.Controls.Add(BtnEventos);
        roundedPanel1.Controls.Add(BtnEmprendimiento);
        roundedPanel1.Controls.Add(BtnParticipantes);
        roundedPanel1.Location = new System.Drawing.Point(16, 8);
        roundedPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        roundedPanel1.Name = "roundedPanel1";
        roundedPanel1.Size = new System.Drawing.Size(307, 777);
        roundedPanel1.TabIndex = 0;
        // 
        // BtnResultadoEventos
        // 
        BtnResultadoEventos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        BtnResultadoEventos.Location = new System.Drawing.Point(24, 397);
        BtnResultadoEventos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        BtnResultadoEventos.Name = "BtnResultadoEventos";
        BtnResultadoEventos.Size = new System.Drawing.Size(253, 48);
        BtnResultadoEventos.TabIndex = 10;
        BtnResultadoEventos.Text = "Resultados Eventos";
        BtnResultadoEventos.UseVisualStyleBackColor = false;
        // 
        // BtnFacultades
        // 
        BtnFacultades.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        BtnFacultades.Location = new System.Drawing.Point(26, 131);
        BtnFacultades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        BtnFacultades.Name = "BtnFacultades";
        BtnFacultades.Size = new System.Drawing.Size(251, 48);
        BtnFacultades.TabIndex = 7;
        BtnFacultades.Text = "Facultades";
        BtnFacultades.UseVisualStyleBackColor = false;
        // 
        // BtnEventos
        // 
        BtnEventos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        BtnEventos.Location = new System.Drawing.Point(24, 306);
        BtnEventos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        BtnEventos.Name = "BtnEventos";
        BtnEventos.Size = new System.Drawing.Size(251, 48);
        BtnEventos.TabIndex = 9;
        BtnEventos.Text = "Eventos";
        BtnEventos.UseVisualStyleBackColor = false;
        BtnEventos.Click += BtnEventos_Click;
        // 
        // BtnEmprendimiento
        // 
        BtnEmprendimiento.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        BtnEmprendimiento.Location = new System.Drawing.Point(26, 42);
        BtnEmprendimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        BtnEmprendimiento.Name = "BtnEmprendimiento";
        BtnEmprendimiento.Size = new System.Drawing.Size(249, 48);
        BtnEmprendimiento.TabIndex = 3;
        BtnEmprendimiento.Text = "Emprendimientos";
        BtnEmprendimiento.UseVisualStyleBackColor = false;
        BtnEmprendimiento.Click += BtnEmprendimiento_Click;
        // 
        // BtnParticipantes
        // 
        BtnParticipantes.BackColor = System.Drawing.Color.FromArgb(((int)((byte)224)), ((int)((byte)224)), ((int)((byte)224)));
        BtnParticipantes.Location = new System.Drawing.Point(24, 222);
        BtnParticipantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        BtnParticipantes.Name = "BtnParticipantes";
        BtnParticipantes.Size = new System.Drawing.Size(251, 48);
        BtnParticipantes.TabIndex = 8;
        BtnParticipantes.Text = "Participantes";
        BtnParticipantes.UseVisualStyleBackColor = false;
        BtnParticipantes.Click += BtnParticipantes_Click;
        // 
        // roundedPanel2
        // 
        roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)250)), ((int)((byte)250)), ((int)((byte)250)));
        roundedPanel2.BorderColor = System.Drawing.Color.LightGray;
        roundedPanel2.BorderRadius = 20;
        roundedPanel2.BorderSize = 1;
        roundedPanel2.Controls.Add(LblUserName);
        roundedPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
        roundedPanel2.Location = new System.Drawing.Point(0, 810);
        roundedPanel2.Name = "roundedPanel2";
        roundedPanel2.Size = new System.Drawing.Size(338, 73);
        roundedPanel2.TabIndex = 5;
        // 
        // LblUserName
        // 
        LblUserName.AutoSize = true;
        LblUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
        LblUserName.Location = new System.Drawing.Point(24, 17);
        LblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        LblUserName.Name = "LblUserName";
        LblUserName.Size = new System.Drawing.Size(114, 25);
        LblUserName.TabIndex = 4;
        LblUserName.Text = "Default user";
        // 
        // panel2
        // 
        panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        panel2.Controls.Add(label1);
        panel2.Dock = System.Windows.Forms.DockStyle.Top;
        panel2.Location = new System.Drawing.Point(0, 0);
        panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(1581, 55);
        panel2.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        label1.Location = new System.Drawing.Point(676, 13);
        label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(370, 35);
        label1.TabIndex = 8;
        label1.Text = "Administrar emprendimientos";
        // 
        // MainFormView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ButtonFace;
        ClientSize = new System.Drawing.Size(1581, 940);
        Controls.Add(panel1);
        Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
        Text = "Form1";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    private System.Windows.Forms.Panel PnlContenedor;
    private System.Windows.Forms.Panel panel3;
    private Button BtnEmprendimiento;
    private Label LblUserName;
    private Panel panel2;
    private Label label1;
    private System.Windows.Forms.Button BtnParticipantes;
    private System.Windows.Forms.Button BtnFacultades;
    private System.Windows.Forms.Button BtnEventos;
    private System.Windows.Forms.Button BtnResultadoEventos;
    private WinForms.Views.Util.RoundedPanel roundedPanel2;
    private WinForms.Views.Util.RoundedPanel roundedPanel1;
}