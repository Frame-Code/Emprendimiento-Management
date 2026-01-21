using Datos.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Impl
{
    public class SpExecutor(IConfiguration configuration) : ISpExecutor
    {

        public async Task<IEnumerable<VerParticipantesDto>> ConsultarParticipantes()
        {
            List<VerParticipantesDto> participantesDtos = new List<VerParticipantesDto>();
            SqlConnection conn = new SqlConnection(configuration.GetConnectionString("AppDb"));
            try
            {
                await conn.OpenAsync();
                using SqlCommand cmd = new SqlCommand("SpConsultarParticipantes", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                using SqlDataReader reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    VerParticipantesDto persona = new VerParticipantesDto
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Telefono = reader.GetString(3),
                        Identificacion = reader.GetString(4),
                        CargoParticipante = reader.GetString(5)
                    };
                    participantesDtos.Add(persona);
                }
                return participantesDtos;

            } catch(Exception)
            {
                return participantesDtos;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
