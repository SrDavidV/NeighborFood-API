using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Preferencias = new HashSet<Preferencia>();
            Reseñas = new HashSet<Reseña>();
        }
        [Required (ErrorMessage = "el campo Cedula es requerido")]
        public long PK_Cedula { get; set; }
        [Required(ErrorMessage = "el campo Nombre es requerido")]
        public string CLI_Nombre { get; set; } = null!;
        [Required(ErrorMessage = "el campo Apellido es requerido")]
        public string CLI_Apellido { get; set; } = null!;
        [Required(ErrorMessage = "ingrese una contraseña valida")]
        public string CLI_Password { get; set; } = null!;
        public DateTime CLI_FechaRegistro { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "el campo Telefono es requerido")]
        public string CLI_Telefono { get; set; } = null!;
        [Required(ErrorMessage = "el campo Ciudad es requerido")]
        public string CLI_Ciudad { get; set; } = null!;
        [Required(ErrorMessage = "el campo Correo es requerido")]
        [EmailAddress(ErrorMessage = "ingrese un correo valido")]
        public string CLI_Correo { get; set; } = null!;
        [Required(ErrorMessage = "el campo Genero es requerido")]
        public string? CLI_Genero { get; set; }
        public int? CLI_Puntos { get; set; }
        public bool CLI_Estado { get; set; } = true;

        public virtual ICollection<Preferencia> Preferencias { get; set; }
        public virtual ICollection<Reseña> Reseñas { get; set; }
    }
}
