using System;
using System.Collections.Generic;

namespace NeighbodFood2.Models
{
    public partial class Promocion
    {
        public int PK_PromoID { get; set; }
        public int PRO_Descuento { get; set; }
        public int PRO_PuntosCanje { get; set; }
        public long? FK_RestauranteID { get; set; }

        public virtual Restaurante? Restaurante { get; set; }
    }
}
