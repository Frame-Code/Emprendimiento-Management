using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl
{
    public class AgendaServiceImpl(
        ICronogramaRepository cronogramaRepository,
        IPresentacionRepository presentacionRepository
    ) : IAgendaService
    {
        public async Task<ResponseDto> RegistrarCronogramaAsync(CronogramaDto dto)
        {
            var entity = new Cronograma
            {
                Fecha = dto.Fecha,
                Hora = dto.Hora,
                Ubicacion = dto.Ubicacion
            };

            await cronogramaRepository.CreateAsync(entity);

            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Cronograma registrado correctamente."
            };
        }

        public async Task<ResponseDto> RegistrarPresentacionAsync(PresentacionDto dto)
        {
            var entity = new Presentacion
            {
                Expositor = dto.Expositor,
                Orden = dto.Orden,
                Fecha = dto.Fecha,
                Hora = dto.Hora,
                Ubicacion = dto.Ubicacion
            };

            await presentacionRepository.CreateAsync(entity);

            return new ResponseDto
            {
                IsSuccess = true,
                Message = "Presentación registrada correctamente."
            };
        }

        public async Task<List<CronogramaDto>> ListarCronogramasAsync()
        {
            var lista = await cronogramaRepository.ListarAsync();

            return lista.Select(c => new CronogramaDto
            {
                Fecha = c.Fecha,
                Hora = c.Hora,
                Ubicacion = c.Ubicacion
            }).ToList();
        }

        public async Task<List<PresentacionDto>> ListarPresentacionesAsync()
        {
            var lista = await presentacionRepository.ListarAsync();

            return lista.Select(p => new PresentacionDto
            {
                Expositor = p.Expositor,
                Orden = p.Orden,
                Fecha = p.Fecha,
                Hora = p.Hora,
                Ubicacion = p.Ubicacion
            }).ToList();
        }
    }
}
