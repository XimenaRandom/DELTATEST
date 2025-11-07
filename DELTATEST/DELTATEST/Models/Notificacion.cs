using DeltaTestAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("NOTIFICACION")]
    public class Notificacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNotificacion { get; set; }

        // FKs
        [Column("id_evaluacion")]
        public int? IdEvaluacion { get; set; }

        [Column("id_administrador")]
        public int? IdAdministrador { get; set; }

        [Required]
        [Column("id_usuario_destino")]
        public int IdUsuarioDestino { get; set; }

        // Atributos
        [Column("mensaje")]
        public string Mensaje { get; set; }

        [Column("fecha_envio")]
        public DateTime? FechaEnvio { get; set; }

        [Column("tipo_notificacion")]
        public string TipoNotificacion { get; set; }

        // Propiedades de Navegación
        [ForeignKey(nameof(IdEvaluacion))]
        public Evaluacion Evaluacion { get; set; }

        [ForeignKey(nameof(IdAdministrador))]
        public Administrador AdministradorEmisor { get; set; }

        [ForeignKey(nameof(IdUsuarioDestino))]
        public Usuario UsuarioDestino { get; set; }
    }
}