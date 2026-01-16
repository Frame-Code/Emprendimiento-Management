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
       
        public async Task<List<FotoDto>> ListarFotosAsync()
        {
            return await db.Fotos
                .Select(f => new FotoDto
                {
                    Id = f.Id,
                    ImageUrl = f.ImageUrl,
                    EmprendimientoId = db.EmprendimientoFotos
                        .Where(ef => ef.FotosId == f.Id)
                        .Select(ef => ef.EmprendimientosId)
                        .FirstOrDefault()
                })
                .ToListAsync();
        }

        public async Task<ResponseDto> GuardarComentarioAsync(ComentarioDto comentario)
        {
            try
            {
                db.Comentarios.Add(new Comentario
                {
                    IdEmprendimiento = comentario.IdEmprendimiento,
                    Texto = comentario.Texto,
                    HoraCreacion = comentario.HoraCreacion,
                    IdUsuario = comentario.IdUsuario // <--- ESTO ES LO QUE SQL PIDE
                });
                await db.SaveChangesAsync();
                return new ResponseDto { IsSuccess = true };
            }
            catch (Exception ex)
            {
                // Si hay error, captura el mensaje interno de SQL
                return new ResponseDto { IsSuccess = false, Message = ex.InnerException?.Message ?? ex.Message };
            }
        }
    }
}