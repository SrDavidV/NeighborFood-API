using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class EstadoClienteDTO
    {
        [Required]
        public bool CLI_Estado { get; set; }
    }
}
