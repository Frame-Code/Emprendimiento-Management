using Controller;
using Microsoft.Extensions.DependencyInjection;
using Modelo.Properties;
using Shared;
using WinForms.Views.UserControls;
using WinForms.Views.Util;

namespace WinForms.Views;

public partial class MainFormView : Form, IViewRolType
{
    public ViewType ViewType => ViewType.Administrador;
    public string UserName { get; set; } = "Usuario";
    public IEnumerable<MenuOptionsDto> MenuOptionsDto { get; set; }
    private readonly IServiceProvider _serviceProvider;
    private readonly EmprendimientosUc _emprendimientosUc;
    private readonly CalendariodeActividadesView _calendarioActividadesView;
    private readonly VerParticipantesView _verParticipantesView;
    private readonly MenuOpcionesController _menuOpcionesController;

    public MainFormView(
        EmprendimientosUc emprendimientosUc, 
        CalendariodeActividadesView calendarioActividadesView, 
        VerParticipantesView verParticipantesView,
        MenuOpcionesController menuOpcionesController,
        IServiceProvider serviceProvider)
    {
        _emprendimientosUc = emprendimientosUc;
        _calendarioActividadesView = calendarioActividadesView;
        _verParticipantesView = verParticipantesView;
        _menuOpcionesController = menuOpcionesController;
        _serviceProvider = serviceProvider;
        InitializeComponent();
        Utils.ConfigureForm(this);
    }
    
    public void ShowForm(Action closeWindows)
    {
        LblUserName.Text = UserName;
        FormClosed += (s, e) => closeWindows();
        Utils.ConfigureForm(this);
        Show();
    }

    private void CargarModulo(UserControl modulo)
    {
        PnlContenedor.Controls.Clear();
        modulo.Dock = DockStyle.Fill;
        modulo.Visible = true;
        PnlContenedor.Controls.Add(modulo);
        modulo.BringToFront();
    }

    private void BtnEmprendimiento_Click(object sender, EventArgs e)
    {
        CargarModulo(_emprendimientosUc);
    }

    private void BtnParticipantes_Click(object sender, EventArgs e)
    {
        try
        {
            CargarModulo(_verParticipantesView);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al abrir participantes: " + ex.Message);
        }
    }

    private void BtnEventos_Click(object sender, EventArgs e)
    {
        try
        {
            CargarModulo(_calendarioActividadesView);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al abrir calendario de actividades: " + ex.Message);
        }
    }

    private void BtnGenerales_Click(object sender, EventArgs e)
    {
        var menusByGrupo = MenuOptionsDto
            .Where(menu => string.Equals(menu.Grupo, "MAESTRO_GENERAL_ADM", StringComparison.InvariantCultureIgnoreCase))
            .ToList();
        
        if (menusByGrupo.Count == 0)
        {
            MessageBox.Show("No se pudo cargar las opciones de este boton, consulte a sistemas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        menusByGrupo.ForEach(menu =>
        {
            var item = new ToolStripMenuItem(menu.Nombre) { Name = menu.Code };
            item.Click += ItemClick; 
            MenuOptions.Items.Add(item);
        });
    }
    
    private void ItemClick(object? sender, EventArgs e)
    {
        if(sender is not ToolStripMenuItem item) 
            return;

        var code = item.Name;
        if (code == null)
        {
            MessageBox.Show("No se puede cargar el modulo seleccionado, consultar a sistemas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        var response = _menuOpcionesController.MenuOptionsHandler(code);
        using (var scope = _serviceProvider.CreateScope())
        {
            
        }

    }

    
    
}