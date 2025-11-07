using DeltaTestAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("ADMINISTRADOR")]
    public class Administrador : Usuario
    {
        // El IdUsuario de Usuario es la PK aquí.

        [Column("cargo")]
        public string Cargo { get; set; }

        // Propiedades de navegación (Relaciones 1:N)
        public ICollection<Evaluacion> EvaluacionesAsignadas { get; set; }
        public ICollection<Notificacion> NotificacionesEnviadas { get; set; }
    }
}