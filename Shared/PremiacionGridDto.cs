namespace Shared;

public class PremiacionGridDto
{
    public int Id { get; init; }
    public string Nombre { get; init; } = null!;
    public string? Observacion { get; init; }
    public DateTime FechaInicioPremiacion { get; init; }
    public DateTime FechaFinPremiacion { get; init; }
    public DateTime FechaCreacion { get; init; }
}