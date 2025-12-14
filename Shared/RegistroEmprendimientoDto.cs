namespace Shared
{
    public class RegistroEmprendimientoDto
    {
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int IdFacultad { get; set; }
        public int IdRubroEmprendimiento { get; set; }
        public List<FileDto> fotos { get; set; }
    }
}
