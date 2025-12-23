namespace Modelo.Properties;

public class MenuOpciones
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string Grupo { get; set; } = null!;
    public int IdRolUsuario { get; set; }
    public RolUsuario RolUsuario { get; set; } = null!;
}