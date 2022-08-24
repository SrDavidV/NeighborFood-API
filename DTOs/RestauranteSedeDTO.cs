using NeighbodFood2.Models;
using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class RestauranteSedeDTO
    {
        public long PK_RestauranteID { get; set; }
        public string RESTA_Nombre { get; set; } = null!;
        public string? RESTA_Correo { get; set; }
        public string RESTA_Imagen { get; set; } = null!;
        public ICollection<SedeDTO> Sedes { get; set; }
    }
}
