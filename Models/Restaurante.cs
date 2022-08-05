using System;
using System.Collections.Generic;

namespace NeighbodFood2.Models
{
    public partial class Restaurante
    {
        public Restaurante()
        {
            Promociones = new HashSet<Promocion>();
            Reseñas = new HashSet<Reseña>();
            Sedes = new HashSet<Sede>();
            Administradores = new HashSet<Administrador>();
        }

        public long PK_RestauranteID { get; set; }
        public string RESTA_Nombre { get; set; } = null!;
        public string? RESTA_Correo { get; set; }

        public virtual ICollection<Promocion> Promociones { get; set; }
        public virtual ICollection<Reseña> Reseñas { get; set; }
        public virtual ICollection<Sede> Sedes { get; set; }

        public virtual ICollection<Administrador> Administradores { get; set; }
    }
}
