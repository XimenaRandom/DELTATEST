using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("AREA")]
    public class Area
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdArea { get; set; }

        [Required]
        [Column("nombre_area")]
        [MaxLength(100)]
        public string NombreArea { get; set; }

        // Propiedades de navegación
        public ICollection<Evaluacion> Evaluaciones { get; set; }
    }
}