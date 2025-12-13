using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AppContext(DbContextOptions<AppContext> options) : DbContext(options)
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

        public DbSet<Cronograma> Cronogramas { get; set; }//nuevo
        public DbSet<Presentacion> Presentaciones { get; set; }//nuevo 
        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Facultades
            modelBuilder.Entity<Facultad>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(200);
                b.Property(x => x.Descripcion).HasMaxLength(1000);
            });

            // Rubros
            modelBuilder.Entity<RubroEmprendimiento>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(200);
                b.Property(x => x.Descripcion).HasMaxLength(1000);
            });

            // Cargos Participante
            modelBuilder.Entity<CargoParticipante>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(200);
                b.Property(x => x.Descripcion).HasMaxLength(1000);
            });

            // Emprendimientos
            modelBuilder.Entity<Emprendimiento>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(300);
                b.Property(x => x.Descripcion).HasMaxLength(2000);
                b.Property(x => x.LogoPath).HasMaxLength(500);

                // Relaciones
                b.HasOne(x => x.Facultad)
                    .WithMany()
                    .HasForeignKey(x => x.IdFacultad)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(x => x.RubroEmprendimiento)
                    .WithMany()
                    .HasForeignKey(x => x.IdRubroEmprendimiento)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Participantes
            modelBuilder.Entity<Participante>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Nombres).IsRequired().HasMaxLength(200);
                b.Property(x => x.Apellidos).IsRequired().HasMaxLength(200);
                b.Property(x => x.FotoPath).HasMaxLength(500);
                b.Property(x => x.NumeroTelefono).IsRequired(). HasMaxLength(15);
                b.Property(x => x.NumeroIdentificacion).IsRequired().HasMaxLength(15);

                b.HasOne(x => x.Emprendimiento)
                    .WithMany(e => e.Participantes)
                    .HasForeignKey(x => x.IdEmprendimiento)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(x => x.CargoParticipante)
                    .WithMany()
                    .HasForeignKey(x => x.IdCargoParticipante)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasIndex(pa => new
                {
                    pa.NumeroIdentificacion
                }).IsUnique();

                b.HasIndex(pa => new
                {
                    pa.NumeroTelefono
                }).IsUnique();
            });

            // Categorias de premio
            modelBuilder.Entity<CategoriaPremio>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(200);
                b.Property(x => x.Descripcion).HasMaxLength(1000);
            });

            // Eventos
            modelBuilder.Entity<Evento>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(300);
                b.Property(x => x.Descripcion).HasMaxLength(2000);
                b.Property(x => x.Ubicacion).HasMaxLength(500);
            });

            // AgendaPresentaciones
            modelBuilder.Entity<AgendaPresentacion>(b =>
            {
                b.HasKey(x => x.Id);

                b.HasOne(x => x.Evento)
                    .WithMany()
                    .HasForeignKey(x => x.IdEvento)
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne(x => x.Emprendimiento)
                    .WithMany()
                    .HasForeignKey(x => x.IdEmprendimiento)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // ResultadoEvento
            modelBuilder.Entity<ResultadoEvento>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Puesto).IsRequired();

                b.HasOne(x => x.Emprendimiento)
                    .WithMany()
                    .HasForeignKey(x => x.IdEmprendimiento)
                    .OnDelete(DeleteBehavior.Restrict);

                b.HasOne(x => x.CategoriaPremio)
                    .WithMany()
                    .HasForeignKey(x => x.IdCategoriaPremio)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Usuarios y roles
            modelBuilder.Entity<RolUsuario>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Nombre).IsRequired().HasMaxLength(200);
                b.Property(x => x.Codigo).IsRequired().HasMaxLength(100);
                b.HasIndex(x => x.Codigo).IsUnique();
            });

            modelBuilder.Entity<Usuario>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.NombreUsuario).IsRequired().HasMaxLength(200);
                b.Property(x => x.Contrasenia).IsRequired().HasMaxLength(2000);
                b.HasIndex(x => x.NombreUsuario).IsUnique();

                b.HasOne(x => x.RolUsuario)
                    .WithMany()
                    .HasForeignKey(x => x.IdRolUsuario)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Votos
            modelBuilder.Entity<Voto>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.FechaCreacion).IsRequired();

                b.HasOne(x => x.Emprendimiento)
                    .WithMany()
                    .HasForeignKey(x => x.IdEmprendimiento)
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne(x => x.Usuario)
                    .WithMany()
                    .HasForeignKey(x => x.IdUsuario)
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasIndex(x => new 
                { 
                    x.IdEmprendimiento, 
                    x.IdUsuario 
                }).IsUnique();
            });

            // Comentarios
            modelBuilder.Entity<Comentario>(b =>
            {
                b.HasKey(x => x.Id);
                b.Property(x => x.Texto).IsRequired().HasMaxLength(2000);
                b.Property(x => x.HoraCreacion).IsRequired();

                b.HasOne(x => x.Usuario)
                    .WithMany()
                    .HasForeignKey(x => x.IdUsuario)
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne(x => x.Emprendimiento)
                    .WithMany()
                    .HasForeignKey(x => x.IdEmprendimiento)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
