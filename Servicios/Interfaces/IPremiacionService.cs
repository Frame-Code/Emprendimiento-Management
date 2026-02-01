using Modelo;
using Shared;

namespace Servicios.Interfaces;

/// <summary>
/// Operaciones de negocio para la gestión de premiaciones y emisión de reportes.
/// </summary>
public interface IPremiacionService
{
    /// <summary>Lista todas las premiaciones.</summary>
    Task<List<PremiacionDto>> ListarPremiacionesAsync();

    /// <summary>Obtiene una premiación por su identificador.</summary>
    Task<PremiacionDto?> ObtenerPremiacionPorIdAsync(int id);

    /// <summary>Crea una nueva premiación.</summary>
    Task<ResponseDto> CrearPremiacionAsync(PremiacionDto dto);

    /// <summary>Genera un reporte PDF asociado a una premiación.</summary>
    /// <param name="reportName">Nombre/título del archivo a generar.</param>
    /// <param name="typeReport">Tipo de reporte a generar.</param>
    /// <param name="IdPremiacion">Identificador de la premiación.</param>
    Task<ResponseDto> GenerateReport(string reportName, TypeReport typeReport, int IdPremiacion);

    /// <summary>Obtiene la premiación vigente (disponible para votar).</summary>
    Task<PremiacionDto?> ObtenerPremiacionDisponible();

    /// <summary>Registra un voto de un usuario para un emprendimiento en una premiación.</summary>
    Task<ResponseDto> Votar(int idPremiacion, int idEmprendimiento, string username);
}
