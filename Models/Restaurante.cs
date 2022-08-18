using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required (ErrorMessage ="el campo correo es requerido")] 
        public string? RESTA_Correo { get; set; }
        public string RESTA_Imagen { get; set; } = null!;

        public virtual ICollection<Promocion> Promociones { get; set; }
        public virtual ICollection<Reseña> Reseñas { get; set; }
        public virtual ICollection<Sede> Sedes { get; set; }

        public virtual ICollection<Administrador> Administradores { get; set; }
    }
}
