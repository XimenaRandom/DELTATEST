using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }

        [Required]
        [MaxLength(255)]
        public string NombreCompleto { get; set; }

        [Required]
        public string Contrasena { get; set; } // En un proyecto real, esto debe ser un hash

        [Required]
        [MaxLength(50)]
        public string Ci { get; set; }

        [MaxLength(50)]
        public string Telefono { get; set; }

        [MaxLength(255)]
        public string Correo { get; set; }

        [MaxLength(100)]
        public string Expedicion { get; set; }

        // Propiedades de navegación (Relaciones)
        public ICollection<DatoAcademico> DatosAcademicos { get; set; }
        public ICollection<Notificacion> NotificacionesRecibidas { get; set; }
        // Nota: Las subclases (Admin, Evaluado) heredarán de esta clave por defecto.
    }
}