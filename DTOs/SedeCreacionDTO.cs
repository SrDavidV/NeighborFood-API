using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class SedeCreacionDTO
    {
        [Required]
        public string SED_Direccion { get; set; } = null!;
        [Required]
        public string? SED_Telefono { get; set; }
        [Required]
        public long? FK_RestauranteID { get; set; }
        [Required]
        [Range(-90, 90)]
        public double Latitud { get; set; }
        [Required]
        [Range(-180, 180)]
        public double Longitud { get; set; }
    }
}
