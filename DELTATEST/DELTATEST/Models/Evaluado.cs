using DELTATEST.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("EVALUADO")]
    public class Evaluado : Usuario // Aquí indicamos la herencia
    {
        public DateTime? FechaIngreso { get; set; }

        public string Observaciones { get; set; }

        [MaxLength(50)]
        public string EstadoEvaluado { get; set; }

        [MaxLength(100)]
        public string PuestoARotar { get; set; }

        // Propiedades de navegación
        public ICollection<Evaluacion> Evaluaciones { get; set; }
        public ICollection<EvaluadoConvocatoria> EvaluadoConvocatorias { get; set; }
    }
}