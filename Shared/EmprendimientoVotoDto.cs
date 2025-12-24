namespace Shared;

public class EmprendimientoVotoDto
{
    public int IdEmprendimiento { get; init; }
    public string Nombre { get; init; } = null!;
    public string Facultad { get; init; } = null!;
    public string Rubro { get; init; } = null!;
    public int CantidadVotos { get; init; } 
}