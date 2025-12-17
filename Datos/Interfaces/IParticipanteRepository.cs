using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IParticipanteRepository : IRepository<Participante>
    {
        Task<bool> ExisteIdentificacionAsync(string identificacion);
        Task<bool> ExisteTelefonoAsync(string telefono);
        Task UpdateAsync(Participante entity);


    }
}