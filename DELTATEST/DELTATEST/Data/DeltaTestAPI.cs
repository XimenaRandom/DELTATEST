using DeltaTestAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DeltaTestAPI.Data
{
    public class DeltaTestAPIDbContext : DbContext
    {
        public DeltaTestAPIDbContext(DbContextOptions<DeltaTestAPIDbContext> options) : base(options) { }

        // Mapeo de Tablas a DbSets
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Evaluado> Evaluados { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Pasante> Pasantes { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Convocatoria> Convocatorias { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<DatoAcademico> DatosAcademicos { get; set; }
        public DbSet<EvaluadoConvocatoria> EvaluadoConvocatorias { get; set; }


        // Usamos OnModelCreating para configurar claves compuestas (M:N) y herencia
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la clave compuesta para la tabla intermedia
            modelBuilder.Entity<EvaluadoConvocatoria>()
                .HasKey(ec => new { ec.IdUsuario, ec.IdConvocatoria });

            // Configuraciones específicas de herencia (Table-per-Hierarchy)
            // Ya que usamos herencia de clave compartida (One-to-One), 
            // EF Core ya lo maneja bien con las FKs definidas en las clases.
        }
    }
}