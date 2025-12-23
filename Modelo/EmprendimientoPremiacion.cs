namespace Modelo;

public class EmprendimientoPremiacion
{
    public int IdEmprendimiento { get; set; }
    public Emprendimiento Emprendimiento { get; set; } = null!;
    public int IdPremiacion { get; set; }
    public  Premiacion Premiacion { get; set; } = null!;
}