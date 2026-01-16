using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Interfaces;


namespace Datos.Impl
{
    public class ComentarioFotoRepositoryImpl : IComentarioFotoRepository
    {
        private readonly AppContext _context;

        public ComentarioFotoRepositoryImpl(AppContext context)
        {
            _context = context;
        }

        public async Task Agregar(ComentarioFoto comentario)
        {
            _context.ComentariosFoto.Add(comentario);
            await _context.SaveChangesAsync();
        }
    }
}
