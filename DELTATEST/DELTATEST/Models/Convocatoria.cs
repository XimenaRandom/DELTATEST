using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("CONVOCATORIA")]
    public class Convocatoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdConvocatoria { get; set; }

        [Column("fecha_convocatoria")]
        public DateTime? FechaConvocatoria { get; set; }

        [Required]
        [Column("nombre_convocatoria")]
        [MaxLength(255)]
        public string NombreConvocatoria { get; set; }

        [Column("estado_convocatoria")]
        [MaxLength(50)]
        public string EstadoConvocatoria { get; set; }

        // Propiedades de navegación para la relación M:N
        public ICollection<EvaluadoConvocatoria> EvaluadoConvocatorias { get; set; }
    }
}