using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Neighborfood.DTOs
{
    public class ReseñaCreacionDTO
    {
        public string? RES_Contenido { get; set; }
        [Required(ErrorMessage = "el campo calificación es requerido")]
        public double RES_Calificacion { get; set; }

    }
}
