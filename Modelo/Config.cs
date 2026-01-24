namespace Modelo;

public class Config
{
    public int Id { get; set; }
    public bool ExecuteInit { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}