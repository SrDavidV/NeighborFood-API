using Neighborfood.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace NeighbodFood2.DTOs
{
    public class RestauranteCreacionDTO
    {
        [Required (ErrorMessage = "El NIT del restaurante es requerido")]
        public long PK_RestauranteID { get; set; }
        [Required(ErrorMessage = "El nombre del restaurante es requerido")]
        public string RESTA_Nombre { get; set; } = null!;
        [Required(ErrorMessage = "el campo correo es requerido")]
        public string? RESTA_Correo { get; set; }
        [PesoImagenValidacion(pesoMaximoEnMegaBytes: 4)]
        [TipoArchivoValidacion(grupoTipoArchivo: GrupoTipoArchivo.Imagen)]
        public IFormFile RESTA_Imagen { get; set; } = null!;


    }
}
