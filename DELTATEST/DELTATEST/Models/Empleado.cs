using DeltaTestAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("EMPLEADO")]
    public class Empleado : Evaluado
    {
        // El IdUsuario de Evaluado es la PK aquí.

        [Column("puesto_actual")]
        public string PuestoActual { get; set; }
    }
}