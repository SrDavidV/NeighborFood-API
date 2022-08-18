using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class RestauranteCreacionDTO
    {
        public long PK_RestauranteID { get; set; }
        public string RESTA_Nombre { get; set; } = null!;
        [Required(ErrorMessage = "el campo correo es requerido")]
        public string? RESTA_Correo { get; set; }
        public IFormFile RESTA_Imagen { get; set; } = null!;


    }
}
