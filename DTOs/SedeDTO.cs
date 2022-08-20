using NetTopologySuite.Geometries;

namespace NeighbodFood2.DTOs
{
    public class SedeDTO
    {
        public string SED_Direccion { get; set; } = null!;
        public string? SED_Telefono { get; set; }
        public long? FK_RestauranteID { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
