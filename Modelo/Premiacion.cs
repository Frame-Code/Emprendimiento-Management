namespace Modelo;

public class Premiacion
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string? Observacion { get; set; } 
    public DateTime FechaInicioPremiacion { get; set; }
    public DateTime FechaFinPremiacion { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public ICollection<EmprendimientoPremiacion> Emprendimientos = new List<EmprendimientoPremiacion>();
    public ICollection<VotoPremiacion> Votos { get; set; } = new List<VotoPremiacion>();
}