using Modelo;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces
{
    /// <summary>
    /// Reglas de negocio para gestión de emprendimientos y catálogos asociados.
    /// </summary>
    public interface IEmprendimientoService
    {
        /// <summary>Lista los rubros de emprendimiento.</summary>
        Task<List<RubroEmprendimiento>> ListarRubrosAsync();

        /// <summary>Registra un nuevo emprendimiento con sus datos y fotos.</summary>
        /// <param name="dto">Datos del emprendimiento.</param>
        /// <returns>Resultado de la operación.</returns>
        Task<ResponseDto> RegistrarEmprendimientoAsync(RegistroEmprendimientoDto dto);

        /// <summary>Lista las facultades disponibles.</summary>
        Task<List<Facultad>> ListarFacultadesAsync();

        /// <summary>Lista los emprendimientos existentes en formato DTO.</summary>
        Task<List<EmprendimientoDto>> ListarEmprendimientosAsync();

        /// <summary>Elimina un emprendimiento por su identificador.</summary>
        Task DeleteByIdAsync(int id);

        /// <summary>Obtiene un emprendimiento por su identificador.</summary>
        Task<Emprendimiento?> ObtenerPorIdAsync(int id);

        /// <summary>Lista emprendimientos con detalle para vistas de estudiantes.</summary>
        Task<List<Emprendimiento>> ListarEmprendimientosEstudiantesAsync();
    }
}
