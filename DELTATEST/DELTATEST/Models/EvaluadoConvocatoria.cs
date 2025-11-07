using DeltaTestAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("EVALUADO_CONVOCATORIA")]
    public class EvaluadoConvocatoria
    {
        // NOTA: La clave compuesta se define en el DbContext (Paso 3 de la guía anterior)

        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("id_convocatoria")]
        public int IdConvocatoria { get; set; }

        // Propiedades de Navegación
        [ForeignKey(nameof(IdUsuario))]
        public Evaluado Evaluado { get; set; }

        [ForeignKey(nameof(IdConvocatoria))]
        public Convocatoria Convocatoria { get; set; }
    }
}