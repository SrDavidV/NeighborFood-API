using NeighbodFood2.Models;

namespace NeighbodFood2.DTOs
{
    public class RestauranteDTO
    {
        public long PK_RestauranteID { get; set; }
        public string RESTA_Nombre { get; set; } = null!;
        public string? RESTA_Correo { get; set; }
        public string RESTA_Imagen { get; set; } = null!;
        public List<SedeDTO> Sedes {get; set;}
    }
}
