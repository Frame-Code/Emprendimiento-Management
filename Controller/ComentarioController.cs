using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Controller;

public class ComentarioController(IComentarioService service)
{
    public async Task<ResponseDto> Guardar(string content, string username, int idEmprendimiento) =>
        await service.Save(content, username, idEmprendimiento);
}