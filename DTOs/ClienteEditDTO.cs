using System.ComponentModel.DataAnnotations;

namespace Neighborfood.DTOs
{
    public class ClienteEditDTO
    { 
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CLI_Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CLI_Apellido { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CLI_Password { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CLI_Telefono { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CLI_Ciudad { get; set; } = null!;
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "Ingrese un correo valido")]
        public string CLI_Correo { get; set; } = null!;
        public string? CLI_Genero { get; set; }
    }
}
