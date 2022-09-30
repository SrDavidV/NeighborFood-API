using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class LoginCliente
    {
        [Required(ErrorMessage = "el campo Correo es requerido")]
        [EmailAddress(ErrorMessage = "ingrese un correo valido")]
        public string CLI_Correo { get; set; } = null!;

        public string CLI_Password { get; set; } = null!;
    }
}
