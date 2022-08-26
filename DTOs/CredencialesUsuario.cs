using System.ComponentModel.DataAnnotations;

namespace Neighborfood.DTOs
{
    public class CredencialesUsuario
    {
        [Required(ErrorMessage ="Email requerido")]
        [EmailAddress(ErrorMessage = "Ingrese un correo valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Password requerido")]
        public string Password { get; set; }
    }
}
