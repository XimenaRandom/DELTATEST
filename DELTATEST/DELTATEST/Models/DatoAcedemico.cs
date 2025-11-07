using DeltaTestAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeltaTestAPI.Models
{
    [Table("DATO_ACADEMICO")]
    public class DatoAcademico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDatoAcademico { get; set; }

        // Clave Foránea a USUARIO
        [Column("id_usuario")]
        public int IdUsuario { get; set; }

        [Column("titulo_academico")]
        public string TituloAcademico { get; set; }

        [Column("lugar_estudio")]
        public string LugarEstudio { get; set; }

        [Column("carrera")]
        public string Carrera { get; set; }

        // Propiedad de Navegación
        [ForeignKey(nameof(IdUsuario))]
        public Usuario Usuario { get; set; }
    }
}