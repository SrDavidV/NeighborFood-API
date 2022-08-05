using System;
using System.Collections.Generic;

namespace NeighbodFood2.Models
{
    public partial class Administrador
    {
        public Administrador()
        {
            Restaurantes = new HashSet<Restaurante>();
        }

        public long PK_CedulaADM { get; set; }
        public string ADM_Nombre { get; set; } = null!;
        public string ADM_Apellido { get; set; } = null!;
        public string? ADM_Genero { get; set; }
        public string ADM_Correo { get; set; } = null!;
        public string ADM_Password { get; set; } = null!;
        public string ADM_Telefono { get; set; } = null!;

        public virtual ICollection<Restaurante> Restaurantes { get; set; }
    }
}
