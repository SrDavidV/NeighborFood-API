using System.ComponentModel.DataAnnotations;

namespace Neighborfood.DTOs
{
    public class ClienteCreateDTO
    {

        [Required(ErrorMessage = "el campo Cedula es requerido")]
        public long PK_Cedula { get; set; }

        [Required(ErrorMessage = "el campo Nombre es requerido")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Campo Nombre solo permite letras")]
        public string CLI_Nombre { get; set; } = null!;

        [Required(ErrorMessage = "el campo Apellido es requerido")]
        [RegularExpression(@"^[a-zA-Z]+[ a-zA-Z-_]*$", ErrorMessage = "Campo apellido solo permite letras")]
        public string CLI_Apellido { get; set; } = null!;

        [Required(ErrorMessage = "Ingrese una contraseña")]
        public string CLI_Password { get; set; } = null!;

        [Required(ErrorMessage = "el campo Telefono es requerido")]
        public string CLI_Telefono { get; set; } = null!;
        [Required(ErrorMessage = "el campo Ciudad es requerido")]
        public string CLI_Ciudad { get; set; } = null!;
        [Required(ErrorMessage = "el campo Correo es requerido")]
        [EmailAddress(ErrorMessage = "Ingrese un correo valido")]
        public string CLI_Correo { get; set; } = null!;
        [Required(ErrorMessage = "el campo Genero es requerido")]
        public string? CLI_Genero { get; set; }
    }
}
