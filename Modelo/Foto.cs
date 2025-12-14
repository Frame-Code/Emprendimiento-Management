namespace Modelo;

public class Foto
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = null!;
    public string FileName { get; set; } = null!;
    public string FileExtension { get; set; } = null!;
    public ICollection<Emprendimiento> Emprendimientos { get; set; } = new List<Emprendimiento>();
}