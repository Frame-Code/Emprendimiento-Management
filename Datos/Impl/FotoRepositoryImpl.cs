using Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Datos.Impl
{
    public class FotoRepositoryImpl : IFotoRepository
    {
        private readonly AppContext _context;

        public FotoRepositoryImpl(AppContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Foto foto)
        {
            await _context.Fotos.AddAsync(foto);
            await _context.SaveChangesAsync();
        }
    }
}
