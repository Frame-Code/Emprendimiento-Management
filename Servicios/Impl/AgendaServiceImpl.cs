using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl
{
    public class AgendaServiceImpl : IAgendaService
    {
        private readonly IAgendaPresentacionRepository _agendaPresentacionRepository;
        private readonly IEmprendimientoRepository _emprendimientoRepository;

        public AgendaServiceImpl(
            IAgendaPresentacionRepository agendaPresentacionRepository,
            IEmprendimientoRepository emprendimientoRepository)
        {
            _agendaPresentacionRepository = agendaPresentacionRepository;
            _emprendimientoRepository = emprendimientoRepository;
        }

        public async Task<ResponseDto> RegistrarAgendaPresentacionAsync(AgendaPresentacionDto dto)
        {
            // Obtener agenda SOLO del evento seleccionado
            var listaActual = await _agendaPresentacionRepository.ListarPorEventoAsync(dto.IdEvento);

            // Calcular nuevo orden correcto
            int nuevoOrden = listaActual.Any()
                ? listaActual.Max(a => a.Orden) + 1
                : 1;

            var entity = new AgendaPresentacion
            {
                IdEvento = dto.IdEvento,
                IdEmprendimiento = dto.IdEmprendimiento,
                Orden = nuevoOrden
            };

            await _agendaPresentacionRepository.CreateAsync(entity);

            return new ResponseDto
            {
                IsSuccess = true,
                Message = $"Presentación agendada con orden #{nuevoOrden}"
            };
        }




        public async Task<List<AgendaPresentacionDto>> ListarAgendaPorEventoAsync(int idEvento)
        {
            var agenda = await _agendaPresentacionRepository.ListarPorEventoAsync(idEvento);

            return agenda
                .OrderBy(a => a.Orden)
                .Select(a => new AgendaPresentacionDto
                {
                    Id = a.Id,
                    IdEvento = a.IdEvento,
                    IdEmprendimiento = a.IdEmprendimiento,
                    Orden = a.Orden
                })
                .ToList();
        }

        public async Task<List<ExpositorDto>> ListarExpositoresAsync()
        {
            var emprendimientos = await _emprendimientoRepository.ListarAsync();

            return emprendimientos
                .Select(e => new ExpositorDto
                {
                    Id = e.Id,
                    Nombre = e.Nombre
                })
                .ToList();
        }
    }
}