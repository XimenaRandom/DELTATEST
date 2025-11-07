using DeltaTestAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("EVALUACION")]
    public class Evaluacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvaluacion { get; set; }

        // FKs
        [Column("id_evaluado")]
        public int IdEvaluado { get; set; }

        [Column("id_administrador")]
        public int? IdAdministrador { get; set; }

        [Column("id_area")]
        public int? IdArea { get; set; }

        // Atributos
        [Column("fecha_evaluacion")]
        public DateTime? FechaEvaluacion { get; set; }

        [Column("nota", TypeName = "decimal(5, 2)")]
        public decimal? Nota { get; set; }

        [Column("estado_evaluacion")]
        public string EstadoEvaluacion { get; set; }

        [Required]
        [Column("tipo_evaluacion")]
        public string TipoEvaluacion { get; set; } // Usando string en lugar de ENUM para compatibilidad con EF Core

        // Propiedades de Navegación
        [ForeignKey(nameof(IdEvaluado))]
        public Evaluado Evaluado { get; set; }

        [ForeignKey(nameof(IdAdministrador))]
        public Administrador Administrador { get; set; }

        [ForeignKey(nameof(IdArea))]
        public Area Area { get; set; }

        public ICollection<Notificacion> Notificaciones { get; set; }
    }
}