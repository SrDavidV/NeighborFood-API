
using NeighbodFood2.Models;

namespace NeighbodFood2.DTOs
{
    public class PlatoDTO
    {
        public int PK_PlatoID { get; set; }
        public string PLA_Nombre { get; set; } = null!;
        public double PLA_Precio { get; set; }
        public string? PLA_Descripcion { get; set; }
        public string? PLA_Ingredientes { get; set; }
        public int PLA_Categoria { get; set; }
        public virtual ICollection<Fotografia> Fotografias { get; set; }
    }
}
