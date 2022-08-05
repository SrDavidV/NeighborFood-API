using System;
using System.Collections.Generic;

namespace NeighbodFood2.Models
{
    public partial class Fotografia
    {
        public int PK_FotoID { get; set; }
        public string FOT_Ruta { get; set; } = null!;
        public int? FK_PlatoID { get; set; }

        public virtual Plato? Plato { get; set; }
    }
}
