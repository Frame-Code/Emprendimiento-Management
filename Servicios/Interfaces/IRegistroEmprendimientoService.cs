using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    public interface IRegistroEmprendimientoService
    {
        Task<List<RubroEmprendimiento>> ListarRubrosAsync();
        Task<ResponseDto> RegistrarEmprendimientoAsync(RegistroEmprendimientoDto dto);
        Task<List<Facultad>> ListarFacultadesAsync();
        Task<List<EmprendimientoDto>> ListarEmprendimientosAsync();
        Task DeleteByIdAsync(int id);
        Task<Emprendimiento?> ObtenerPorIdAsync(int id);
        Task<List<Emprendimiento>> ListarEmprendimientosEstudiantesAsync();
    }
}
