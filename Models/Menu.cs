using System;
using System.Collections.Generic;

namespace NeighbodFood2.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Platos = new HashSet<Plato>();
            Sedes = new HashSet<Sede>();
        }

        public int PK_MenuID { get; set; }

        public virtual ICollection<Plato> Platos { get; set; }
        public virtual ICollection<Sede> Sedes { get; set; }
    }
}
