using Datos.Interfaces;
using Modelo;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Impl
{
    public class AgendaServiceImpl : IAgendaService
    {
        private readonly IAgendaPresentacionRepository _agendaRepository;
        private readonly IEmprendimientoRepository _emprendimientoRepository;

        public AgendaServiceImpl(
            IAgendaPresentacionRepository agendaRepository,
            IEmprendimientoRepository emprendimientoRepository)
        {
            _agendaRepository = agendaRepository;
            _emprendimientoRepository = emprendimientoRepository;
        }

    
        public async Task<ResponseDto> RegistrarAgendaPresentacionAsync(AgendaPresentacionDto dto)
        {
           
            int maxOrden = await _agendaRepository.ObtenerMaxOrdenGlobalAsync();

            var entity = new AgendaPresentacion
            {
                IdEvento = dto.IdEvento,
                IdEmprendimiento = dto.IdEmprendimiento,
                Orden = maxOrden + 1
            };

            await _agendaRepository.CreateAsync(entity);

            return new ResponseDto
            {
                IsSuccess = true,
                Message = $"Presentación registrada con orden #{entity.Orden}"
            };
        }

       
        public async Task<List<AgendaPresentacionDto>> ListarAgendaPorEventoAsync(int idEvento)
        {
            var lista = await _agendaRepository.ListarPorEventoAsync(idEvento);

            return lista
                .OrderBy(a => a.Orden)
                .Select(a => new AgendaPresentacionDto
                {
                    IdEvento = a.IdEvento,
                    IdEmprendimiento = a.IdEmprendimiento,
                    Orden = a.Orden
                })
                .ToList();
        }

        public async Task<List<ExpositorDto>> ListarExpositoresAsync()
        {
            var emprendimientos = await _emprendimientoRepository.ListarAsync();

            return emprendimientos.Select(e => new ExpositorDto
            {
                Id = e.Id,
                Nombre = e.Nombre
            }).ToList();
        }
    }
}