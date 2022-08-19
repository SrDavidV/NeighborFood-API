using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.Models
{
    public class Categoria
    {
        public Categoria()
        {
            Platos = new HashSet<Plato>();
        }

        [Key]
        public int PK_CategoriaID { get; set; }
        [Required]
        public string CategoriaNombre { get; set; }
        [Required]
        public string CategoriaImagen { get; set; } 
        public ICollection<Plato> Platos { get; set; }
    }
}
