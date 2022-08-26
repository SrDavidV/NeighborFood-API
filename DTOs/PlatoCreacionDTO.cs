using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class PlatoCreacionDTO
    {
        [Required(ErrorMessage = "Ingrese el nombre del plato")]
        public string PLA_Nombre { get; set; } = null!;
        [Required(ErrorMessage = "Ingrese el precio del plato")]
        public double PLA_Precio { get; set; }
        public string? PLA_Descripcion { get; set; }
        public string? PLA_Ingredientes { get; set; }
        [Required(ErrorMessage = "Ingrese el id de la categoria")]
        public int PLA_Categoria { get; set; }
       
    }
}
