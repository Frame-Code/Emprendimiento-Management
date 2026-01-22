using Modelo;
using Shared;

namespace Servicios.Interfaces;

public interface IPremiacionService
{
    Task<List<PremiacionDto>> ListarPremiacionesAsync();
    Task<PremiacionDto?> ObtenerPremiacionPorIdAsync(int id);
    Task<ResponseDto> CrearPremiacionAsync(PremiacionDto dto);

    Task<ResponseDto> GenerateReport(string reportName, TypeReport typeReport, int IdPremiacion);

    Task<PremiacionDto?> ObtenerPremiacionDisponible();
    Task<ResponseDto> Votar(int idPremiacion, int idEmprendimiento, string username);

}