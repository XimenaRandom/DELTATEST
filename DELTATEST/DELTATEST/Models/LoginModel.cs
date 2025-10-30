using System.ComponentModel.DataAnnotations;

namespace DELTATEST.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Correo inválido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string? Password { get; set; }
    }
}
