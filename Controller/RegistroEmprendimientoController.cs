using Modelo;
using Shared;

namespace Controller
{
    public class RegistroEmprendimientoController
    {
        public async Task<List<RubroEmprendimiento>> ListarRubrosAsync() 
        { 
            await Task.Delay(100);
            return null; //Por el momento
        }

        public async Task<ResponseDto> RegistrarEmprendimientoAsync(RegistroEmprendimientoDto dto) 
        { 
            await Task.Delay(100);
            return null; //Por el momento
        }

        public async Task<List<Facultad>> ListarFacultadesAsync() 
        { 
            await Task.Delay(100);
            return null; //Por el momento
        }
    }
}
