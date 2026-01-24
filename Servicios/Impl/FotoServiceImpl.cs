using Modelo;
using Servicios.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Servicios.Impl
{
    public class FotoServiceImpl(Datos.AppContext db) : IFotoService
    {
        public async Task<List<FotoDto>> ListarFotosPorEmprendimientoAsync(int idEmprendimiento)
        {
          
            var fotos = await db.FotoEmprendimientos
                .AsNoTracking()
                .Include(x => x.Foto)
                .Where(x => x.IdEmprendimiento == idEmprendimiento)
                .ToListAsync();
            
            return fotos
                .Select(f => new FotoDto
                {
                    Id = f.Foto.Id,
                    ImageUrl = f.Foto.ImageUrl,
                    EmprendimientoId = f.IdEmprendimiento
                }).ToList();
        }

        public async Task<ResponseDto> GuardarComentarioAsync(ComentarioDto comentario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(comentario.Texto))
                    return new ResponseDto
                    {
                        IsSuccess = false,
                        Message = "El comentario no puede estar vacío."
                    };

                db.Comentarios.Add(new Comentario
                {
                    IdEmprendimiento = comentario.IdEmprendimiento,
                    Texto = comentario.Texto,
                    HoraCreacion = DateTime.Now,
                    IdUsuario = comentario.IdUsuario
                });

                await db.SaveChangesAsync();
                return new ResponseDto { IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new ResponseDto
                {
                    IsSuccess = false,
                    Message = ex.InnerException?.Message ?? ex.Message
                };
            }
        }
    }
}