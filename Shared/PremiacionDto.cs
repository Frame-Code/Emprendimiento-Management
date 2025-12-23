namespace Shared;

public class PremiacionDto
{
    public int Id { get; init; }
    public string Nombre { get; init; } = null!;
    public string? Observaciones { get; init; }
    public DateTime FechaInicioPremiacion { get; init; }
    public DateTime FechaFinPremiacion { get; init; }
    public DateTime FechaCreacion { get; init; } = DateTime.Now;
    public ICollection<EmprendimientoDto> EmprendimientosDto { get; set; } = new List<EmprendimientoDto>();
    public ICollection<VotoDto> Votos { get; set; } = new List<VotoDto>();
}