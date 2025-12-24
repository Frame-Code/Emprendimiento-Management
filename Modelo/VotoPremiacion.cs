namespace Modelo;

public class VotoPremiacion
{
    public int IdVoto { get; set; }
    public Voto Voto { get; set; } = null!;
    public int IdPremiacion { get; set; }
    public Premiacion Premiacion { get; set; } = null!;
    public DateTime FechaCreacion { get; set; }
    
}