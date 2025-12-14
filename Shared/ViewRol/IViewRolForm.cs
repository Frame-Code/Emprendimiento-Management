namespace Shared.ViewRol
{
    public interface IViewRolForm : IViewRol
    {
        string UserName { get; set; }
        IEnumerable<MenuOptionsDto> MenuOptionsDto { get; set; }
        void ShowForm(Action closeWindows);
    }
}
