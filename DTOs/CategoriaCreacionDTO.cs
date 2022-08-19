using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class CategoriaCreacionDTO
    {
        [Required]
        public string CategoriaNombre { get; set; }
        [Required]
        public IFormFile CategoriaImagen { get; set; }
    }
}
