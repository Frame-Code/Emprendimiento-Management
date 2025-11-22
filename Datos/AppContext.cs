using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class AppContext(DbContextOptions<AppContext> options) : DbContext
    {
        public DbSet<Emprendimiento> Emprendimientos { get; set; }
        public DbSet<Facultad> Facultades { get; set; }
        public DbSet<RubroEmprendimiento> RubrosEmprendimiento { get; set; }
        public DbSet<Participante> Participantes { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<AgendaPresentacion> AgendaPresentaciones { get; set; }
        public DbSet<CategoriaPremio> CategoriasPremio { get; set; }
        public DbSet<ResultadoEvento> ResultadoEventos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Voto> Votos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }
        public DbSet<CargoParticipante> CargosParticipante { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

        }


        }
}
