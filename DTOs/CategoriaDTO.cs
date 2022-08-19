using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class CategoriaDTO
    {
        public int PK_CategoriaID { get; set; }
        public string CategoriaNombre { get; set; }
        public string CategoriaImagen { get; set; }
    }
}
