using System;
using System.Collections.Generic;

namespace NeighbodFood2.Models
{
    public partial class Plato
    {
        public Plato()
        {
            Fotografias = new HashSet<Fotografia>();
            Preferencia = new HashSet<Preferencia>();
            Menus = new HashSet<Menu>();
        }

        public int PK_PlatoID { get; set; }
        public string PLA_Nombre { get; set; } = null!;
        public double PLA_Precio { get; set; }
        public string? PLA_Descripcion { get; set; }
        public string? PLA_Ingredientes { get; set; }

        public int PLA_Categoria { get; set; }  

        public virtual ICollection<Fotografia> Fotografias { get; set; }
        public virtual ICollection<Preferencia> Preferencia { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
