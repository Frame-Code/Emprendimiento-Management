using Servicios.Interfaces;
using Shared;

namespace Controller;

public class PremiacionController(IPremiacionService service)
{
    public async Task<List<PremiacionDto>> ListarPremiacionesAsync() =>
        await service.ListarPremiacionesAsync();
    
    public async Task<PremiacionDto?> ObtenerPremiacionPorIdAsync(int id) =>
        await service.ObtenerPremiacionPorIdAsync(id);

    public async Task<ResponseDto> CrearPremiacionAsync(PremiacionDto dto) =>
        await service.CrearPremiacionAsync(dto);
}