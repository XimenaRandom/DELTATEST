using DeltaTestAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("PASANTE")]
    public class Pasante : Evaluado
    {
        // El IdUsuario de Evaluado es la PK aquí.

        [Column("puesto_solicitado")]
        public string PuestoSolicitado { get; set; }

        // Clave Foránea a USUARIO (Supervisor)
        [Column("id_supervisor")]
        public int? IdSupervisor { get; set; }

        // Propiedad de Navegación
        [ForeignKey(nameof(IdSupervisor))]
        public Usuario Supervisor { get; set; }
    }
}