using Shared.ViewRol;

namespace WinForms.Views.UserControls;

public partial class RubroEmprendimientoUc : UserControl, IViewRolUc
{
    public ViewType ViewType { get; } = ViewType.Administrador;
    public string UcCode { get; set; } = "RBR";
    
    public RubroEmprendimientoUc()
    {
        InitializeComponent();
    }

}