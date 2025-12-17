namespace Shared.ViewRol;

public enum ViewType
{
    Administrador,
    Estudiante,
}

public interface IViewRol
{
    ViewType ViewType { get; }
}