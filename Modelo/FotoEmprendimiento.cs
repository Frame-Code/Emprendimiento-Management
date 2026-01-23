namespace Modelo;

public class FotoEmprendimiento
{
    public int Id { get; set; }
    public int IdEmprendimiento { get; set; }
    public Emprendimiento Emprendimiento { get; set; } = null!;
    public int IdFoto { get; set; }
    public Foto  Foto { get; set; } = null!;
}