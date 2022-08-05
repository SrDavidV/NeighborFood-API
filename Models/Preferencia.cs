using System;
using System.Collections.Generic;

namespace NeighbodFood2.Models
{
    public partial class Preferencia
    {
        public int PK_PreferenciaID { get; set; }
        public int? FK_PlatoID { get; set; }
        public long? FK_ClienteID { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual Plato? Plato { get; set; }
    }
}
