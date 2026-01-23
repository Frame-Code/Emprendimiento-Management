namespace Modelo;

public class FotoParticipante
{
    public int Id { get; set; }
    public int IdParticipante { get; set; }
    public Participante Participante { get; set; } = null!;
    public int IdFoto { get; set; }
    public Foto  Foto { get; set; } = null!;
}