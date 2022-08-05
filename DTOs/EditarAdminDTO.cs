using System.ComponentModel.DataAnnotations;

namespace Neighborfood.DTOs
{
    public class EditarAdminDTO
    {
        [Required]
        [EmailAddress]
        public string  Email { get; set; }
    }
}
