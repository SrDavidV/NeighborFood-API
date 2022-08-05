using System;
using System.Collections.Generic;

namespace NeighbodFood2.Models
{
    public partial class Reseña
    {
        public int PK_ReseñaID { get; set; }
        public string? RES_Contenido { get; set; }
        public double RES_Calificacion { get; set; }
        public DateTime RES_FechaCreacion { get; set; }
        public long? FK_RestauranteID { get; set; }
        public long? FK_ClienteID { get; set; }
        public string? UsuarioId { get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual Restaurante? Restaurante { get; set; }
    }
}
