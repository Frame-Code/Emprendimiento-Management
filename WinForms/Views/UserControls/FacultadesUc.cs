using Shared.ViewRol;

namespace WinForms.Views.UserControls;

public partial class FacultadesUc : UserControl, IViewRolUc
{
    public ViewType ViewType { get; } = ViewType.Administrador;
    public string UcCode { get; set; } = "FCL";
    
    public FacultadesUc()
    {
        InitializeComponent();
    }

}