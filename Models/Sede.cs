using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace NeighbodFood2.Models
{
    public partial class Sede
    {
        public Sede()
        {
            Menu = new HashSet<Menu>();
        }
        public int PK_SedeID { get; set; }

        public string SED_Direccion { get; set; } = null!;
        public string? SED_Telefono { get; set; }
        public long? FK_RestauranteID { get; set; }
        public Point? Ubicacion { get; set; }

        public virtual Restaurante? Restaurante { get; set; }

        public virtual ICollection<Menu> Menu { get; set; }
    }
}
