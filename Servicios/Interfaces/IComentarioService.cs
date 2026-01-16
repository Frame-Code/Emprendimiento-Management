using Modelo;
using Shared;

namespace Servicios.Interfaces;

public interface IComentarioService
{
    Task<ResponseDto> Save(string content, string username, int idEmprendimiento);
}